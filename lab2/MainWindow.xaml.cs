using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab2;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var k = Convert.ToDouble(KInput.Text);
            EmployeeOutput.Content = GetEmployeeWage(k);
            EngineerOutput.Content = GetEngineerWage(k);
        }
        catch (Exception)
        {
            return;
        }
    }

    private double GetEmployeeWage(double k)
    {
        string name;
        double minWage;
        try
        {
            name = EmploeeNameInput.Text;
            minWage = Convert.ToDouble(EmploeeWageInput.Text);
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid input");
            return 0;
        }

        var employee = new Employee(name, minWage);

        return employee.CalculateWage(k);
    }

    private double GetEngineerWage(double k)
    {
        string name;
        double minWage;
        int projects;
        try
        {
            name = EngineerNameInput.Text;
            minWage = Convert.ToDouble(EngineerWageInput.Text);
            projects = Convert.ToInt32(EngineerProjectsInput.Text);
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid input");
            return 0;
        }

        var engineer = new Engineer(name, minWage, projects);

        return engineer.CalculateWage(k);
    }
}
