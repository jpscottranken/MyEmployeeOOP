using System;
using System.Windows.Forms;

/*
 *          ------------------------
            |    Employee          |    Name of class
            ------------------------
            | - id: int            |
            | - firstName: string  |    Class instance variables
            | - lastName: string   |    (- means private)
            | - department: string |
            | - salary: decimal    |
            ------------------------
            | + Employee()         |    Default Constructor
            |                      |    (+ means public)  
            | + Employee(id: int,  |    
            |   firstName: string, |    Full-Arg Constructor
            |   lastName: string,  |    (+ means public)
            |	department: string,| 
            |	salary: decimal)   |
            |	                   |
            | + Id: int            |    Properties
            | + firstName: string  |    (+ means public)
            | + lastName: string   |
            | + Department: string |
            | + Salary: decimal    |
            ------------------------
 *
 */

namespace EmployeeCDProject
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CreateEmployeeUsingDefaultConstructor();

            CreateEmployeeUsingFullArgConstructor();
        }

        private void CreateEmployeeUsingDefaultConstructor()
        {
            Employee employee1 = new Employee();
            txtOutput.Text = "Default Construtor Employee\r\n";
            txtOutput.Text += employee1.ToString();

            UpdateEmployeeUsingDefaultConstructor(employee1);
        }

        private void UpdateEmployeeUsingDefaultConstructor(Employee emp1)
        {
            emp1.Id          = 100;
            emp1.FirstName   = "Jane";
            emp1.LastName    = "Doe";
            emp1.Department  = "Programming";
            emp1.Salary      = 75000M;
            txtOutput.Text += "Updated Default Construtor Employee\r\n";
            txtOutput.Text += emp1.ToString();
        }

        public void CreateEmployeeUsingFullArgConstructor()
        {
            Employee employee2 = new Employee(222,
                                             "John",
                                             "Smith",
                                             "Web Design",
                                             69999.00M);
            employee2.Department = "UX Design";
            employee2.Salary    += 5000;
            txtOutput.Text      += "Full-Arg Construtor Employee\r\n";
            txtOutput.Text      += employee2.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                            "Do You Really Want To Exit The Program?",
                            "EXIT NOW?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
