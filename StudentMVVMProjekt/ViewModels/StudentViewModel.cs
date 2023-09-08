using CommunityToolkit.Mvvm.ComponentModel;
using StudentMVVMProjekt.Models;

namespace StudentMVVMProjekt.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student student;

        [ObservableProperty]
        private string selectedEducationLevel;

        public StudentViewModel()
        {
           this.student = new Student();
           selectedEducationLevel = string.Empty;
        }

        public StudentViewModel(Student student)
        {
            this.student = student;
            selectedEducationLevel=string.Empty;
        }
    }
}
