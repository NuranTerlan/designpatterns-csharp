namespace DesignPatterns
{
    public class EmployeeContactBuilder<T> : EmployeePersonalBuilder<EmployeeContactBuilder<T>> where T: EmployeeContactBuilder<T>
    {
        public T WithEMail(string email)
        {
            Employee.Email = email;
            return (T) this;
        }

        public T WithMainPhone(string mainPhone)
        {
            Employee.PhoneNumMain = mainPhone;
            return (T) this;
        }

        public T WithBackupPhone(string backupPhone)
        {
            Employee.PhoneNumBackup = backupPhone;
            return (T) this;
        }
    }
}