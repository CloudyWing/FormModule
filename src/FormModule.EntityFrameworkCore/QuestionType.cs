namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// Represents a question type.
    /// </summary>
    public class QuestionType : EnumerationBase<QuestionType, short> {

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionType"/> class with the specified value and name.
        /// </summary>
        /// <param name="value">The value of the question type.</param>
        /// <param name="name">The name of the question type.</param>
        protected QuestionType(short value, string? name) : base(value, name) { }

        /// <summary>
        /// Gets the question type for multiple choice(0).
        /// </summary>
        public static QuestionType MultiChoice { get; } = new QuestionType(0, "單選");

        /// <summary>
        /// Gets the question type for multiple selection(1).
        /// </summary>
        public static QuestionType MultiSelection { get; } = new QuestionType(1, "多選");

        /// <summary>
        /// Gets the question type for drop-down list(2).
        /// </summary>
        public static QuestionType DropDownList { get; } = new QuestionType(2, "下拉選單");

        /// <summary>
        /// Gets the question type for short answer(3).
        /// </summary>
        public static QuestionType ShortAnswer { get; } = new QuestionType(3, "簡答");

        /// <summary>
        /// Gets the question type for long answer(4).
        /// </summary>
        public static QuestionType LongAnswer { get; } = new QuestionType(4, "詳答");
    }
}
