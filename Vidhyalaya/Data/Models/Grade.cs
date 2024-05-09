//Grade:Label(1,2,3 etc.), Class Teacher, Medium, Subjects, Session Year

using System.ComponentModel.DataAnnotations;
public class Grade{
[Key]
public int Label { get; set; }
public string ClassTeacher { get; set; }
public string Medium { get; set; }

public string Subjects { get; set; }

public DateTime Session { get; set; }
}