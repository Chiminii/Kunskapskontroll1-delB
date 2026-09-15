Course math = new("Math", 0);
Course eng = new("English", 20);
Course art = new("Art", 20);
Course physics = new("Physics", 1);

Student kei = new("Kei");
Student mai = new("Mai");
Student lay = new("Lay");
Student lei = new("Lei");

// math.Enroll(kei);
// eng.Enroll(kei);
// eng.Enroll(kei);
// kei.Join(math);
// kei.Join(eng);
// kei.Join(eng);
// kei.Leave(eng);
// eng.Remove(kei);
// kei.Leave(eng);
// math.Remove(kei);
// kei.Leave(math);
// eng.Enroll(kei);
eng.Enroll(lei);
eng.Enroll(kei);
eng.Enroll(mai);
eng.Enroll(lay);
// eng.RollCall();
// eng.Remove(kei);
// eng.Remove(lei);

lei.Leave(eng);
lei.Leave(eng);
// lei.Leave(eng);

// mai.Join(math);
// mai.Join(physics);
// mai.Schedule();
// mai.Join(physics);
// lay.Join(physics);
// mai.Join(art);

// physics.Enroll(mai);
// physics.Enroll(mai);
// physics.Enroll(lay);
// physics.Remove(lay);
// art.Enroll(mai);
// art.Remove(lay);
mai.Schedule();


// Console.WriteLine(art);
// Console.WriteLine(eng);

// Console.WriteLine(kei);
// Console.WriteLine(mai);
// Console.WriteLine(lay);