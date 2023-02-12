namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters {
    /// <summary>
    /// Specifies that automatic validation should be stopped for a method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class StopAutoValidationAttribute : Attribute { }
}
