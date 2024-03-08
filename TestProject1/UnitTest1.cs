namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddStudent_ShouldAddStudentToList()
        {
            // Arrange
            StudentManager studentManager = new StudentManager();

            // Act
            Student student = new Student("John Doe", 20, 1);
            studentManager.AddStudent(student);

            // Assert
            Assert.Contains(student, studentManager.GetStudents());
        }

    }
}