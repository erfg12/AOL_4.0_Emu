namespace aol.Helpers;
class MDIHelper
{
    /// <summary>
    /// Open a form that has a default constructor
    /// </summary>
    /// <typeparam name="T">Form class</typeparam>
    /// <param name="parentForm">MDI Parent</param>
    public static void OpenForm<T>(Form parentForm, Point? position = null) where T : Form, new()
    {
        T form = new T();
        form.MdiParent = parentForm;
        if (position != null)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = position ?? new Point(0, 0);
        }
        form.Show();
    }

    /// <summary>
    /// Open a form that has a constructor with an argument
    /// </summary>
    /// <param name="formFactory">Form class</param>
    /// <param name="mdiParent">MDI Parent</param>
    public static void OpenForm(Func<Form> formFactory, Form mdiParent, Point? position = null)
    {
        Form form = formFactory();
        form.MdiParent = mdiParent;
        form.Show();

        if (position != null)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = position ?? new Point(0, 0);
        }
    }
}
