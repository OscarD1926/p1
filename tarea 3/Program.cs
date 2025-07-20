Console.WriteLine("Bienvenido a mi lista de Contactes");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
List<string> names = new List<string>();
List<string> lastnames = new List<string>();
List<string> addresses = new List<string>();
List<string> telephones = new List<string>();
List<string> emails = new List<string>();
List<int> ages = new List<int>();
List<bool> bestFriends = new List<bool>();


while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   6. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            {
                //Console.WriteLine("Digite el nombre de la persona");
                //string name = Console.ReadLine();
                //Console.WriteLine("Digite el apellido de la persona");
                //string lastname = Console.ReadLine();
                //Console.WriteLine("Digite la dirección");
                //string address = Console.ReadLine();
                //Console.WriteLine("Digite el telefono de la persona");
                //string phone = Console.ReadLine();
                //Console.WriteLine("Digite el email de la persona");
                //string email = Console.ReadLine();
                //Console.WriteLine("Digite la edad de la persona en números");
                //int age = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                ////var temp = Convert.ToInt32(Console.ReadLine());
                ////bool isBestFriend;
                ////if (temp == 1)
                ////{ isBestFriend = true; }
                ////else
                ////{ isBestFriend = false; }
                //bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

                //var id = ids.Count + 1;
                //ids.Add(id);
                //names.Add(id, name);
                //lastnames.Add(id, lastname);
                //addresses.Add(id, address);
                //telephones.Add(id, phone);
                //emails.Add(id, email);
                //ages.Add(id, age);
                //bestFriends.Add(id, isBestFriend);

                AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

            }
            break;
        case 2: //extract this to a method
            {
                Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                Console.WriteLine($"____________________________________________________________________________________________________________________________");
                for (int a = 0; a < ids.Count; a++ )
                {

                    //string isBestFriendStr;

                    //if (isBestFriend == true)
                    //{
                    //    isBestFriendStr = "Si";
                    //}
                    //else {
                    //    isBestFriendStr = "No";
                    //}

                    
                    Console.WriteLine($"{names[a]}         {lastnames[a]}         {addresses[a]}         {telephones[a]}            {emails[a]}            {ages[a]}          {bestFriends[a]}");
                }

            }
            break;
        case 3: //search
            {
                Console.Write("Introudce el a a buscar: ");

                int searchID = Convert.ToInt32(Console.ReadLine());
                int index = ids.IndexOf(searchID);

                if (index != -1)
                {
                    Console.WriteLine($"Nombre: {names[index]} | Apellido {lastnames[index]}, | Direccion {addresses[index]}, | Telefono {telephones[index]}, | Correo {emails[index]}, Edad | {ages[index]}, Es mejor amigo?: {bestFriends[index]}");
                }
            }
            break;
        case 4: //modify
            {
                Console.Write("Introduce el ID a editar: ");
                int idtoedit = Convert.ToInt32(Console.ReadLine());
                int idtoseach = ids.IndexOf(idtoedit);

                if (idtoseach != -1)
                {
                    Console.WriteLine($"Nombre: {names[idtoseach]}, Apellido: {lastnames[idtoseach]}, Direccion {addresses[idtoseach]}, Telefono: {telephones[idtoseach]}, Correo {emails[idtoseach]}, Edad: {ages[idtoseach]}, Es tu mejor amigo?: {bestFriends[idtoseach]}");

                    Console.WriteLine("Introduce el nuevo nombre: ");
                    names[idtoseach] = Console.ReadLine();

                    Console.WriteLine("Introduce el nuevo apellido: ");
                    lastnames[idtoseach] = Console.ReadLine();

                    Console.WriteLine("Introduce la nueva direccion: ");
                    addresses[idtoseach] = Console.ReadLine();

                    Console.WriteLine("Introduce el nuevo telefono: ");
                    telephones[idtoseach] = Console.ReadLine();

                    Console.WriteLine("Introduce el nuevo correo: ");
                    emails[idtoseach] = Console.ReadLine();

                    Console.WriteLine("Introduce la nueva edad: ");
                    ages[idtoseach] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sigue siendo tu mejor amigo? ");
                    bestFriends[idtoseach] = Convert.ToBoolean(Console.ReadLine());
                }
                }
                break;
        case 5: //delete
                    {
                        Console.WriteLine("Introduce el ID a borrar: ");
                        int delID = Convert.ToInt32(Console.ReadLine());
                        int eliminar = ids.IndexOf(delID);

                        if (eliminar != -1)
                        {
                            Console.WriteLine("Contacto a eliminar ");
                            Console.WriteLine($"Nombre {names[eliminar]}, Apellido: {lastnames[eliminar]}, Direccion {addresses[eliminar]}, Telefono: {telephones[eliminar]}, Correo {emails[eliminar]}, Edad: {ages[eliminar]}, Es tu mejor amigo?: {bestFriends[eliminar]}");

                            Console.WriteLine("1. Si 2. No");
                            int decide = Convert.ToInt32(Console.ReadLine());

                            if (decide != 1)
                            {
                                ids.RemoveAt(eliminar);
                                names.RemoveAt(eliminar);
                                telephones.RemoveAt(eliminar);
                                addresses.RemoveAt(eliminar);
                                emails.RemoveAt(eliminar);
                                ages.RemoveAt(eliminar);
                                bestFriends.RemoveAt(eliminar);
                                Console.WriteLine("El contacto ha sido eliminado");
                            }
                            else
                            {
                                Console.WriteLine("No se ha podido eliminar el contacto");
                            }
                        }
                        }

                        break;
        case 6:
                            runing = false;
                            break;
                        default:
                            Console.WriteLine("Tu eres o te haces el idiota?");
                            break;
                        }
                    }


                    static void AddContact(List<int> ids, List<string> names, List<string> lastnames, List<string> addresses, List<string> telephones, List<string> emails, List<int> ages, List<bool> bestFriends)
                    {
                        Console.WriteLine("Digite el nombre de la persona");
                        string name = Console.ReadLine();
                        Console.WriteLine("Digite el apellido de la persona");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Digite la dirección");
                        string address = Console.ReadLine();
                        Console.WriteLine("Digite el telefono de la persona");
                        string phone = Console.ReadLine();
                        Console.WriteLine("Digite el email de la persona");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite la edad de la persona en números");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");

                        bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

                        var id = ids.Count + 1;
                        ids.Add(id);
                        names.Add(name);
                        lastnames.Add(lastname);
                        addresses.Add(address);
                        telephones.Add(phone);
                        emails.Add(email);
                        ages.Add(age);
                        bestFriends.Add(isBestFriend);
                    
                
}