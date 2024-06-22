// See https://aka.ms/new-console-template for more information
Parallel.Invoke(
PrintStudentMessage,
PrintEmployeeMessage
    );
void PrintStudentMessage()
{
    var fromStudent = Singleton.Singleton.GetInstance;
    fromStudent.PrintMessage("from student");
}

void PrintEmployeeMessage()
{
    var fromEmployee = Singleton.Singleton.GetInstance;
    fromEmployee.PrintMessage("from employee");
}

Console.Read();