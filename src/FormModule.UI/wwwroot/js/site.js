let originalFetch = window.fetch;

window.fetch = function (input, init) {
    if (!init) {
        init = {};
    }
    if (!init.headers) {
        init.headers = new Headers();
    }

    const token = document.querySelector('input[name="__RequestVerificationToken"]');
    if (token !== null) {
        if (init.headers instanceof Headers) {
            init.headers.append('RequestVerificationToken', token.value);
        } else if (init.headers instanceof Array) {
            init.headers.push(['RequestVerificationToken', token.value]);
        } else {
            init.headers['RequestVerificationToken'] = token.value;
        }
    }

    return originalFetch(input, init);
};

+function () {
    const forms = document.querySelectorAll('form');
    forms.forEach(form => {
        const submitButtons = document.querySelectorAll('[type="submit"]');
        const nonSubmitButtons = document.querySelectorAll('button:not([type="submit"]), a');
        const formElements = form.querySelectorAll('input:not([type="submit"]):not([type="button"])');
        const milliseconds = 3000;

        form.addEventListener('submit', (event) => {
            submitButtons.forEach(button => {
                if (button.form === form) {
                    button.disabled = true

                    setTimeout(() => {
                        button.disabled = false;
                    }, milliseconds);
                }
            });
            nonSubmitButtons.forEach(el => {
                el.disabled = true;
                el.classList.add('disabled');
                setTimeout(() => {
                    el.disabled = false;
                    el.classList.remove('disabled');
                }, milliseconds);
            });

            formElements.forEach(el => {
                if (!el.disabled && !el.readOnly
                    && el.type !== 'submit' && el.type !== 'button'
                    && !el.classList.contains('disabled')
                ) {
                    el.readOnly = true;
                    setTimeout(() => {
                        el.readOnly = false;
                    }, milliseconds);
                }
            });
        });
    });

    document.querySelectorAll('input[type="submit"], input[type="button"], button[type="submit"], button[type="button"]').forEach(function (elem) {
        if (elem.classList.contains('btn-delete')) {
            elem.addEventListener('click', function (event) {
                const result = confirm("是否確定刪除資料？");
                if (!result) {
                    event.preventDefault();
                    event.stopPropagation();
                }
            });
        }
    });
}();

/**
 * @typedef LinkedDropDownList
 * @type {object}
 * @property {function} add - 增加一個單一選單至連動下拉式選單裡
 * @property {function} create - 建立連動式下拉選單
 * @property {function} refreshItems - 重新產生指定的下拉式選單項目
 * /
/**
 * @type {LinkedDropDownList} 連動式下拉式選單清單
 */
class LinkedDropDownList {
    constructor() {
        this.dropDownLists = [];
        this.refreshItems = this.refreshItems.bind(this);
        this.create = this.create.bind(this);
    }

    /**
     * 增加一個單一選單至連動下拉式選單清單裡
     * @param {DropDownList} dropDownList 連動下拉式選單的單一選單
     */
    add(dropDownList) {
        if (!(dropDownList instanceof DropDownList)) {
            throw new TypeError('dropDownList type is error');
        }

        dropDownList.linkedDropDownList = this;
        this.dropDownLists.push(dropDownList);
    }

    /**
     * 建立連動式下拉選單
     */
    create() {
        this.refreshItems(0);

        this.dropDownLists.forEach((dropDownList, index) => {
            dropDownList.select.addEventListener('change', function () {
                const prevValue = this.dropDownLists[index - 1]?.select.value ?? '';
                const values = this.dropDownLists.slice(0, index).map(list => list.select.value);

                for (let j = index + 1; j < this.dropDownLists.length; j++) {
                    this.dropDownLists[j].defaultValue = '';
                }

                dropDownList.changeCallback(dropDownList);
                this.refreshItems(index + 1, prevValue, values);
            }.bind(this));
        });
    }

    /**
     * 重新產生指定的下拉式選單項目
     * @param {number} index - 第幾個下拉式選單
     */
    refreshItems(index) {
        const currentDropDownList = this.dropDownLists[index] || null;
        const nextDropDownList = this.dropDownLists[index + 1] || null;
        const previousDropDownList = this.dropDownLists[index - 1] || null;

        // 記錄前一個下拉選單的值，第二個以後下拉選單才會有作用
        const previousValue = previousDropDownList === null ? '' : previousDropDownList.select.value;

        if (!currentDropDownList) {
            return;
        }

        currentDropDownList.setQuering();

        // 可能查詢會需要比前一個更早之前的 Value
        const values = [];
        for (let i = 0; i < index; i++) {
            values.push(this.dropDownLists[i].select.value);
        }

        const postData = {
            prevValue: previousValue,
            values: values
        };

        // 額外的查詢條件
        for (let key in currentDropDownList.extraParams) {
            const value = currentDropDownList.extraParams[key];

            // 試著從 DOM 取值
            try {
                const element = (currentDropDownList.select.form || document).querySelector(value);
                postData[key] = (typeof value === 'string' && element !== null)
                    ? element.type === 'radio'
                        ? document.querySelector(`${value}:checked`).value
                        : element.type === 'checkbox'
                            ? Array.from(document.querySelectorAll(`${value}:checked`), elem => elem.value)
                            : element.value
                    : value;
            } catch {
                postData[key] = value;
            }
        }

        if (previousDropDownList && !currentDropDownList.allowEmptyPrevValue() && previousDropDownList.select.value === '') {
            currentDropDownList.setNonUsed();

            if (nextDropDownList !== null) {
                this.refreshItems(index + 1);
            }
        } else {
            fetch(currentDropDownList.ajaxUrl, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(postData)
            })
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    throw new Error('Network response was not ok');
                }
            })
            .then(response => {
                currentDropDownList.clearItems();
                if (response.length > 0) {
                    if (currentDropDownList.hasOptionLabel() && response.length > 1) {
                        currentDropDownList.addOptionLabelItem();
                    }

                    for (let i = 0; i < response.length; i++) {
                        currentDropDownList.addItem(response[i]['text'], response[i]['value']);
                    }
                }

                currentDropDownList.changeCallback(currentDropDownList);

                if (nextDropDownList !== null) {
                    this.refreshItems(index + 1);
                }
            })
            .catch(error => {
                console.error('There was a problem with the fetch operation:', error);
            });
        }
    }
}

/**
* 解析 select 的 data- 元素，並在 select.DropDownList 建立 DropDownList
* @function
* @memberof LinkedDropDownList
* @param {HTMLSelectElement} select - select的DOM
* @return {DropDownList} DropDownList
*/
LinkedDropDownList.parseSelect = function (select) {
    if (!select.dropDownList) {
        select.dropDownList = new DropDownList(select);
    }

    return select.dropDownList;
};

/**
 * 解析 querySelectorAll 能找到的 select，解析其 data- 元素，
 * 並在 select.dropDownList 建立 LinkedDropDownList.DropDownList
 * @function
 * @memberof LinkedDropDownList
 * @param {string|Element}- CSS 選擇器或 DOM 元素
 */
LinkedDropDownList.parse = function (selector) {
    const selects = document.querySelectorAll(selector || 'select[data-ajax-url]');
    const selectsWithChildren = document.querySelectorAll(`${selector} [data-ajax-url]`);
    const allSelects = [...selects, ...selectsWithChildren];

    const groups = {};
    allSelects.forEach((select) => {
        const group = select.selectGroup || '';
        if (!groups[group]) {
            groups[group] = [];
        }
        groups[group].push(LinkedDropDownList.parseSelect(select));
    });

    for (const group in groups) {
        const dropDownListLists = new LinkedDropDownList();
        groups[group].forEach((dropDownList) => {
            dropDownListLists.add(dropDownList);
        });
        dropDownListLists.create();
    }
};

/**
* @typedef {Object} DropDownList
* @property {string} ajaxUrl - ajaxUrl 的 url，對應 data-ajax-url
* @property {string} defaultValue - 對應 data-default-value
* @property {string} optionLabel - 是否要有空白選項，對應 data-option-label
* @property {string} nonUsedLabel - 上層 select 未選擇時顯示文字，對應 data-non-used-label
* @property {function} changeCallback - 執行 change 事件時，額外執行的內容
* @property {Object} extraParams - 傳遞至 Ajax Server 的額外參數，Key 不可為 prevValue 和 values
* @property {LinkedDropDownList} DropDownLists - 所屬的 LinkedDropDownList
*/
class DropDownList {
    /**
    * 建立一個 DropDownList 類別的實例
    * @param {HTMLSelectElement} select - <select /> 元素
    * @returns {DropDownList} DropDownList 類別的實例
    */
    constructor(select) {
        this.select = select;
        this.ajaxUrl = '';
        this.defaultValue = '';
        this.optionLabel = null;
        this.nonUsedLabel = null;
        this.changeCallback = () => { };
        this.extraParams = {};
        this.DropDownLists = null;

        // 取得元素屬性值
        const selectKeys = [
            'ajaxUrl', 'defaultValue', 'optionLabel', 'nonUsedLabel', 'changeCallback', 'extraParams'
        ];

        const escapeHtml = (str) => {
            return (str + '').replace(/[&<>]/g, function (m) {
                return ({
                    '&': '&amp;',
                    '<': '&lt;',
                    '>': '&gt;'
                })[m];
            });
        };

        selectKeys.forEach((key) => {
            const value = select.dataset[key];

            if (value || value === '') {
                if (key === 'changeCallback' && typeof value === 'string') {
                    this[key] = eval(escapeHtml(value));
                } else if (key === 'extraParams' && typeof value === 'string') {
                    this.extraParams = JSON.parse(value);
                } else {
                    this[key] = value === null ? null : value.toString();
                }
            }
        });
    }

    /**
     * 增加一個選項
     * @param {string} text - option 的 text
     * @param {string} value - option 的 value
     */
    addItem(text, value) {
        const opts = this.select.options;
        opts.add(new Option(text, value));

        if (this.defaultValue === value) {
            this.select.value = value;
        }
    }

    /**
     * 清除全部的選項
     */
    clearItems() {
        this.select.options.length = 0;
    }

    /**
     * 增加一個空白的選項
     */
    addOptionLabelItem() {
        this.addItem(this.optionLabel, '');
    }

    /**
     * 清除全部的選項，並建立一個選項表示應先選上層下拉式選單內容
     */
    setNonUsed() {
        this.clearItems();
        this.addItem(this.nonUsedLabel, '');
    }

    /**
     * 清除全部的選項，並建立一個顯示查詢中的選項
     */
    setQuering() {
        this.clearItems();
        this.addItem('查詢中...', '');
    }

    /**
     * 檢查是否設定 optionLabel 屬性
     * @returns {boolean} 是否設定 optionLabel 屬性
     */
    hasOptionLabel() {
        return typeof this.optionLabel !== 'undefined' && this.optionLabel !== null;
    }

    /**
     * 檢查是否允許空的上層下拉式選單
     * @returns {boolean} 是否允許空的上層下拉式選單
     */
    allowEmptyPrevValue() {
        return typeof this.nonUsedLabel === 'undefined' || this.nonUsedLabel === null;
    }
}

document.addEventListener('DOMContentLoaded', function () {
    LinkedDropDownList.parse();
});
