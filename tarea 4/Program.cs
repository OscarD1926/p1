using Contactsbyclasses.clases;

Console.WriteLine("Bienvenido a mi lista de Contactes");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;

agenda agenda = new agenda();



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

                agenda.Addcontact();

            }
            break;
        case 2: //extract this to a method
            {
                agenda.visualizar();
            }
            break;
        case 3: //search
            {
               agenda.buscarContactos();
            }
            break;
        case 4: //modify
            {
               agenda.modificarContactos();
            }
            break;
        case 5: //delete
            {
               agenda.eliminarContacto();
             }break;
            
            case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Tu eres o te haces el idiota?");
            break;
    }
}


