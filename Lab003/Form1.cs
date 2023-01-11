namespace Lab003
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<double> gardes = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name = this.textBoxName.Text;
            String id = this.textBoxID.Text;
            String birth = this.textBoxBirth.Text;
            String height = this.textBoxHeight.Text;
            String garde = this.textBoxGarde.Text;
            String field = this.textBoxField.Text;

            int iBirth = Int32.Parse(birth);
            double iHeight = double.Parse(height);
            double iGarde = double.Parse(garde);

            Student newStudent = new Student(name,id,iBirth,iHeight,iGarde,field);
            this.students.Add(newStudent);
            this.gardes.Add(iGarde);

            this.textBoxName.Text = "";
            this.textBoxID.Text = "";
            this.textBoxBirth.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxGarde.Text = "";
            this.textBoxField.Text = "";

            BindingSource source = new BindingSource();
            source.DataSource = this.students;
            this.dataGridView1.DataSource = source;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 length = students.Count;
            double MaxG = gardes.Max();
            Double MinG = gardes.Min();

            textBoxAllStd.Text= length.ToString();
            textBoxMax.Text = MaxG.ToString();
            textBoxMin.Text= MinG.ToString();
        }
    }
}