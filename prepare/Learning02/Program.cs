using System;

Job job1 = new Job();
job1._company = "Microsoft";
job1._jobTitle = "Software engineer";
job1._startYear = 2020;
job1._endYear = 2021;

Job job2 = new Job();
job2._company = "Apple";
job2._jobTitle = "Sales associate";
job2._startYear = 2022;
job2._endYear = 2023;

Resume myResume = new Resume();
myResume._name = "Andrew Nelson";

myResume._jobs.Add(job1);
myResume._jobs.Add(job2);

myResume.Display();
