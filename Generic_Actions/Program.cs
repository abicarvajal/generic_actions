// See https://aka.ms/new-console-template for more information
using Generic_Actions;

Generic_Action<double> actions_double = new Generic_Action<double>(1.55,5.00);
Generic_Action<int> actions_int = new Generic_Action<int>(1, 5);
Generic_Action<float> actions_float = new Generic_Action<float>(1.55f, 5.0f);


//El tipo "string" debe ser un tipo que no acepte valores NULL --> no acepta valores String o clase persona da problema al querer instanciar 
//Generic_Action<string> action_string = new Generic_Action<string>("A", "B");
//Generic_Action<Person> action_class = new Generic_Action<Person>(new Person(),new Person());

Console.WriteLine(actions_double.toString());
Console.WriteLine(actions_int.toString());
Console.WriteLine(actions_float.toString());


