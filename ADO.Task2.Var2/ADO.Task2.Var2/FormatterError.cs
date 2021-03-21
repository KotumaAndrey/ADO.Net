namespace Ado.Task2.Var2
{
    public class FormatterError
    {
        public string ErrorMessage { get; set; }

        public FormatterError Create(string message) => new FormatterError
        {
            ErrorMessage = message
        };
    }
}