            // See https://aka.ms/new-console-template for more information
            /*Disponemos de un vector unidimensional de 20 elementos de tipo carácter. Se pide desarrollar un
            programa que:
            a) Pida una frase al usuario y luego ingrese la frase dentro del arreglo letra por letra. Ayuda: utilizar la
            función Subcadena.
            b) Una vez completado lo anterior, pedirle al usuario un carácter cualquiera y una posición dentro del
            arreglo, y el programa debe intentar ingresar el carácter en la posición indicada, si es que hay lugar
            (es decir la posición está vacía o es un espacio en blanco). De ser posible debe mostrar el vector con
            la frase y el carácter ingresado, de lo contrario debe darle un mensaje al usuario de que esa posición
            estaba ocupada.*/
            int largo = 0, i = 0, pos;
            char[] letras = new char[999];
            string frase;
            char car;
            Console.Write("Ingrese una frase: ");
            frase = Console.ReadLine();
            largo = frase.Length;
            foreach (char letra in frase)
            {
                letras[i] = letra;
                i++;
            }
            Console.Write("Que caracter desea ingresar en el arreglo?: ");
            car = char.Parse(Console.ReadLine());
            Console.Write("En que posicion desea ingresar el caracter? (En total hay " + largo + " posiciones en el arreglo): ");
            pos = int.Parse(Console.ReadLine());

            if (letras[pos] == ' ')
            {
                letras[pos] = car;
                Console.Write("\n\n");
                for (int u = 0; u < largo; u++)
                {
                    Console.Write(letras[u]);
                }
            }
            else
            {
                Console.WriteLine("La posicion que desea sustituir esta ocupada ");
            }
            Console.ReadKey();