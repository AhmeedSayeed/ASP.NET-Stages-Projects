namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Welcome to Students Management System ========");
            StudentsManager studentManager = new StudentsManager();
            while(true)
            {
                ShowMainMenu();
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        while(true)
                        {
                            ShowStudentsMenu();
                            try 
                            {
                                int studentChoice = Convert.ToInt32(Console.ReadLine());
                                if (studentChoice == 1)
                                {
                                    studentManager.DisplayStudents();
                                    Console.WriteLine();
                                }
                                else if (studentChoice == 2)
                                {
                                    studentManager.AddStudent();
                                }
                                else if (studentChoice == 3)
                                {
                                    int editChoice = 0;
                                    while (true)
                                    {
                                        studentManager.DisplayStudents();
                                        if (studentManager.Students.Count == 0)
                                        {
                                            break;
                                        }
                                        try
                                        {
                                            Console.Write("Choose a student to edit: ");
                                            editChoice = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine();
                                            if (editChoice > studentManager.Students.Count || editChoice < 1)
                                            {
                                                Console.WriteLine("Invalid input!");
                                                Console.WriteLine();
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"Error: {ex.Message}");
                                            Console.WriteLine();
                                        }
                                    }
                                    Student student = studentManager.Students[editChoice - 1];
                                    while(true)
                                    {
                                        ShowEditMenu();
                                        try
                                        {
                                            int fieldChoice = Convert.ToInt32(Console.ReadLine());
                                            if (fieldChoice == 1)
                                            {
                                                Console.WriteLine("Enter new ID: ");
                                                int newID = Convert.ToInt32(Console.ReadLine());
                                                student.ID = newID;
                                            }
                                            else if (fieldChoice == 2)
                                            {
                                                Console.WriteLine("Enter new Name: ");
                                                string newName = Console.ReadLine();
                                                student.Name = newName;
                                            }
                                            else if (fieldChoice == 3)
                                            {
                                                Console.WriteLine("Enter new Subject: ");
                                                string newSubject = Console.ReadLine();
                                                student.Subject = newSubject;
                                            }
                                            else if(fieldChoice == 4)
                                            {
                                                Console.WriteLine("Enter new GPA: ");
                                                double newGPA = Convert.ToDouble(Console.ReadLine());
                                                student.GPA = newGPA;
                                            }
                                            else if(fieldChoice == 5)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid input!");
                                            }
                                        }
                                        catch(Exception ex)
                                        {
                                            Console.WriteLine($"Error: {ex.Message}");
                                            Console.WriteLine();
                                        }
                                    }
                                    

                                }
                                else if (studentChoice == 4)
                                {
                                    while(true)
                                    {
                                        studentManager.DisplayStudents();
                                        if(studentManager.Students.Count == 0)
                                        {
                                            break;
                                        }
                                        Console.Write("Choose a student to delete: ");
                                        Console.WriteLine();
                                        try 
                                        {
                                            int deleteChoice = Convert.ToInt32(Console.ReadLine());
                                            if(deleteChoice > studentManager.Students.Count || deleteChoice < 1)
                                            {
                                                Console.WriteLine("Invalid input!");
                                                Console.WriteLine();
                                            }
                                            else
                                            {
                                                studentManager.RemoveStudent(studentManager.Students[deleteChoice - 1]);
                                                break;
                                            }
                                        }
                                        catch(Exception ex)
                                        {
                                            Console.WriteLine($"Error: {ex.Message}");
                                            Console.WriteLine();
                                        }
                                    }
                                }
                                else if (studentChoice == 5)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                    Console.WriteLine();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                                Console.WriteLine();
                            }
                        }
                    }
                    else if (choice == 2)
                    {
                        double averageGPA = studentManager.CalculateAverageGPA();
                        Console.WriteLine(averageGPA != 0 ? $"GPA Average: {averageGPA}" : "Add students first!");
                        Console.WriteLine();
                    }
                    else if (choice == 3)
                    {
                        Student student = studentManager.GetStudentWithMaxGPA();
                        Console.WriteLine(student != null ? student : "Add students first!");
                        Console.WriteLine();
                    }
                    else if (choice == 4)
                    {
                        Student student = studentManager.GetStudentWithMinGPA();
                        Console.WriteLine(student != null ? student : "Add students first!");
                        Console.WriteLine();
                    }
                    else if (choice == 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("======== Thanks for using my app ========");
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("1. Manage Students");
            Console.WriteLine("2. Get GPA Average");
            Console.WriteLine("3. Get Student with highest GPA");
            Console.WriteLine("4. Get Student with lowest GPA");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option: ");
        }

        static void ShowStudentsMenu()
        {
            Console.WriteLine("1. View Students");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Back");
            Console.Write("Please select an option: ");
        }

        static void ShowEditMenu()
        {
            Console.WriteLine("1. ID");
            Console.WriteLine("2. Name");
            Console.WriteLine("3. Subject");
            Console.WriteLine("4. GPA");
            Console.WriteLine("5. Back");
            Console.Write("Please select an option: ");
        }
    }
}
