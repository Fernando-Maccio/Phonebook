using System;
using Library;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string TwilioSandbox = "+14155238886";

            // Crear el phonebook del contacto dueño
            Phonebook TwilioPhonebook = new Phonebook("Twilio", TwilioSandbox, "POO UCU");

            // Agregar contactos a la lista
            TwilioPhonebook.AddContact("Fernando", "+59891412237", "321449745313654");
            TwilioPhonebook.AddContact("Sofía", "+59891714238", "312165489453321");
            TwilioPhonebook.AddContact("Francisco", "+59894265900", "6541324875424");
            TwilioPhonebook.AddContact("Paolo", "+59892370344", "1174842747842416640");

            string[] names = {"Fernando", "Sofía", "Francisco", "Paolo"};

            //Buscar contactos
            List<Contact> contacts = TwilioPhonebook.Search(names);

            // Enviar un Whatsapp y Tweet a los compis
            TwilioPhonebook.SendWhatsAppMessage(names, "Holaaa!");
            TwilioPhonebook.SendTwitterMessage(names, "Holaaa!");
        }
    }
}
