﻿namespace W13_DependancyInjection;

public class Classroom
{
    public ITeacher Teacher { get; set; }
    
    public Classroom(ITeacher teacher)
    {
        Teacher = teacher;
    }
    
    public string GetTeacherInfo()
    {
        return Teacher.GetInfo();
    }
}