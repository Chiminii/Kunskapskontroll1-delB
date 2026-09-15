Course math = new("Math", 0);
Course eng = new("English", 20);
Course art = new("Art", 20);
Course physics = new("Physics", 20);

Student kei = new("Kei");
Student mai = new("Mai");
Student lay = new("Lay");

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
// eng.Enroll(mai);
// eng.Enroll(lay);
// eng.RollCall();

mai.Join(math);
mai.Join(physics);
mai.Join(art);

art.Enroll(mai);
mai.Schedule();


