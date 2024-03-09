using Get_Hash_Code_Equals.Entities;


Client a = new Client{Name = "Henrique", Age = 35};
Client b = new Client { Name = "Henrique", Age = 32 };

Console.WriteLine(a.Equals(b)); // Conteúdo igual = True 
Console.WriteLine(a == b); // Referência de memória diferente = False
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());