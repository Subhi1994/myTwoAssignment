using myTwoAssignment;

// إنشاء موظف دوام كامل
Employee emp1 = new FullTimeEmployee(1, "Ahmad", 1200);

// إنشاء موظف دوام جزئي (مثلاً 40 ساعة ضرب 10 دينار للساعة = 400)
Employee emp2 = new PartTimeEmployee(2, "Omar", 40, 10);

// عرض معلومات أحمد
emp1.DisplayInfo();
emp1.Work();

Console.WriteLine(); // سطر فارغ للترتيب

// عرض معلومات عمر
emp2.DisplayInfo();
emp2.Work();
    
