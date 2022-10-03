using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hardcodeo
    {
        private static List<Operario> listaOperarios = new List<Operario>();
        private static List<Crucero> listaCruceros = new List<Crucero>();
        private static List<Viaje> listaViajes = new List<Viaje>();
        private static List<Pasajero> listaP1 = new List<Pasajero>();

        public static List<Operario> ListaOperarios 
        { 
            get { return Hardcodeo.listaOperarios; } 
            //set
        }

        public static List<Crucero> ListaCruceros 
        { 
            get { return Hardcodeo.listaCruceros; }
            //set { } 
        }

        public static List<Viaje> ListaViajes
        {
            get { return Hardcodeo.listaViajes; }
            set { Hardcodeo.ListaViajes = value; } 
        }

        static Hardcodeo()
        {
            Hardcodeo.InicializarOperariosHardcodeados();
            Hardcodeo.InicializarCrucerosHardcodeados();
            Hardcodeo.InicializarViajesHardcodeados();
            Hardcodeo.InicializarPasajerosHardcodeados();
        }

        #region Hardcodeo de Operarios
        private static void InicializarOperariosHardcodeados()
        {
            Operario op1 = new Operario("Joel", "Mahafud", "37777777", "joe", "1");
            Operario op2 = new Operario("Maximiliano", "Neiner", "30000000", "mneiner", "Abstraccion");
            Operario op3 = new Operario("Facundo", "Rocha", "38888888", "frocha", "Polimorfismo");
            Operario op4 = new Operario("Felipe", "Bustos", "40000000", "fbustos", "Encapsulamiento");

            Hardcodeo.listaOperarios.Add(op1);
            Hardcodeo.listaOperarios.Add(op2);
            Hardcodeo.listaOperarios.Add(op3);
            Hardcodeo.listaOperarios.Add(op4);
        }
        #endregion

        #region Hardcodeo de Cruceros
        private static void InicializarCrucerosHardcodeados()
        {
            Crucero c1 = new Crucero(50, "AA1000", "La Cumbancha Volante", 0, 1, 2, 1250);
            Crucero c2 = new Crucero(100, "BB2000", "Titanic II", 4, 0, 6, 2500);
            Crucero c3 = new Crucero(1000, "CC3000", "The Luxury Placeholder", 12, 6, 10, 10000);
            Crucero c4 = new Crucero(120, "DD4000", "The Wanderer", 0, 3, 3, 2700);
            Crucero c5 = new Crucero(300, "EE5000", "Tom Cruiser", 2, 0, 4, 3200);
            Crucero c6 = new Crucero(200, "FF6000", "Poseidón", 1, 1, 3, 4000);
            Crucero c7 = new Crucero(10, "GG7000", "El Odiseo", 0, 0, 1, 300);

            Hardcodeo.listaCruceros.Add(c1);
            Hardcodeo.listaCruceros.Add(c2);
            Hardcodeo.listaCruceros.Add(c3);
            Hardcodeo.listaCruceros.Add(c4);
            Hardcodeo.listaCruceros.Add(c5);
            Hardcodeo.listaCruceros.Add(c6);
            Hardcodeo.listaCruceros.Add(c7);
        }
        #endregion

        #region Hardcodeo de Viajes
        private static void InicializarViajesHardcodeados()
        {
            DateTime auxDT = DateTime.Today;

            Viaje v1 = new Viaje(auxDT.AddDays(20).AddHours(16), Hardcodeo.listaCruceros[0], EDestino.Montevideo);
            Viaje v2 = new Viaje(auxDT.AddDays(10).AddHours(19), Hardcodeo.listaCruceros[1], EDestino.NuevaYork);
            Viaje v3 = new Viaje(auxDT.AddDays(8).AddHours(23), Hardcodeo.listaCruceros[2], EDestino.Recife);
            Viaje v4 = new Viaje(auxDT.AddDays(-1).AddHours(10), Hardcodeo.listaCruceros[3], EDestino.Taipei);
            Viaje v5 = new Viaje(auxDT.AddDays(7).AddHours(7), Hardcodeo.listaCruceros[4], EDestino.IslaDePascua);
            Viaje v6 = new Viaje(auxDT.AddDays(10).AddHours(9), Hardcodeo.listaCruceros[5], EDestino.Atenas);
            Viaje v7 = new Viaje(auxDT.AddDays(4).AddHours(21), Hardcodeo.listaCruceros[6], EDestino.PuertoMadryn);

            Hardcodeo.listaViajes.Add(v1);
            Hardcodeo.listaViajes.Add(v2);
            Hardcodeo.listaViajes.Add(v3);
            Hardcodeo.listaViajes.Add(v4);
            Hardcodeo.listaViajes.Add(v5);
            Hardcodeo.listaViajes.Add(v6);
            Hardcodeo.listaViajes.Add(v7);

            AgregarPasajerosHardcodeadosAViaje();
        }
        #endregion

        #region Hardcodeo de Pasajeros

        private static void InicializarPasajerosHardcodeados()
        {
            Hardcodeo.listaP1.Add(new Pasajero(true, "Perry", "id", "21764354", new DateTime(17 / 11 / 2021), new Pasaporte("AAB67EBM1KR", "South Africa", new DateTime(25 / 12 / 2022), new DateTime(02 / 11 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Emmanuel", "consectetuer", "48755935", new DateTime(21 / 09 / 2023), new Pasaporte("XHM37CYM2GN", "South Korea", new DateTime(17 / 01 / 2022), new DateTime(14 / 11 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Cadman", "vulputate,", "49124518", new DateTime(25 / 01 / 2023), new Pasaporte("JKO58QON3TG", "Italy", new DateTime(03 / 04 / 2023), new DateTime(26 / 09 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Imelda", "vel", "46263942", new DateTime(02 / 06 / 2022), new Pasaporte("AXI66OKB4QI", "Colombia", new DateTime(16 / 01 / 2022), new DateTime(03 / 01 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Connor", "libero", "3061807", new DateTime(29 / 08 / 2022), new Pasaporte("HWY06WBL9NT", "Brazil", new DateTime(23 / 09 / 2022), new DateTime(29 / 12 / 2021)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Leo", "in,", "13360396", new DateTime(11 / 06 / 2022), new Pasaporte("YOD12XUL5EQ", "Colombia", new DateTime(05 / 07 / 2023), new DateTime(16 / 05 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Gareth", "Vivamus", "36373787", new DateTime(24 / 09 / 2023), new Pasaporte("DHT24MNK0IR", "South Africa", new DateTime(15 / 02 / 2023), new DateTime(27 / 08 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Jonas", "Fusce", "25919249", new DateTime(07 / 12 / 2021), new Pasaporte("CES26RZZ7YD", "Philippines", new DateTime(02 / 08 / 2023), new DateTime(30 / 05 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Jamal", "nunc,", "48880425", new DateTime(16 / 10 / 2022), new Pasaporte("WVJ21WYX5VS", "Italy", new DateTime(17 / 03 / 2023), new DateTime(09 / 05 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Lucius", "est", "55022478", new DateTime(17 / 07 / 2022), new Pasaporte("JQL25SQK6OP", "Colombia", new DateTime(18 / 02 / 2022), new DateTime(09 / 01 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Kadeem", "Donec", "22355879", new DateTime(10 / 12 / 2022), new Pasaporte("JWR62JVE8ON", "Russian Federation", new DateTime(04 / 08 / 2023), new DateTime(08 / 08 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Dennis", "auctor", "25892988", new DateTime(10 / 09 / 2023), new Pasaporte("FXD47RDD7OS", "Mexico", new DateTime(10 / 05 / 2023), new DateTime(13 / 02 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Halla", "at,", "26685519", new DateTime(14 / 04 / 2023), new Pasaporte("IXF26LGL5LU", "Singapore", new DateTime(12 / 06 / 2023), new DateTime(20 / 03 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Dorothy", "lorem", "4876338", new DateTime(08 / 10 / 2022), new Pasaporte("XVK76YLN6UN", "Russian Federation", new DateTime(17 / 02 / 2022), new DateTime(15 / 07 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "David", "Etiam", "50148051", new DateTime(16 / 12 / 2021), new Pasaporte("HWA12KWL4PU", "Russian Federation", new DateTime(03 / 10 / 2022), new DateTime(02 / 07 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Holly", "urna", "27734009", new DateTime(15 / 03 / 2022), new Pasaporte("VBS01WXM1CG", "Chile", new DateTime(08 / 07 / 2022), new DateTime(11 / 02 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Nomlanga", "blandit", "22281024", new DateTime(27 / 11 / 2022), new Pasaporte("WHO80EXG7XK", "Costa Rica", new DateTime(09 / 02 / 2023), new DateTime(29 / 11 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Quyn", "ut", "30703345", new DateTime(26 / 09 / 2023), new Pasaporte("TGR79KQF5MF", "Colombia", new DateTime(13 / 09 / 2022), new DateTime(19 / 07 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Avye", "fames", "16328365", new DateTime(25 / 12 / 2022), new Pasaporte("WFI55NXG7RP", "Italy", new DateTime(26 / 12 / 2021), new DateTime(07 / 04 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Knox", "nonummy", "33643739", new DateTime(27 / 02 / 2022), new Pasaporte("WWE68NRE0EI", "United States", new DateTime(04 / 07 / 2023), new DateTime(23 / 12 / 2021)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Damian", "enim.", "35343382", new DateTime(21 / 09 / 2022), new Pasaporte("WDX86JRP8KX", "Russian Federation", new DateTime(28 / 03 / 2023), new DateTime(12 / 10 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Quentin", "in,", "27037575", new DateTime(12 / 11 / 2022), new Pasaporte("CXE78WCP0VW", "Brazil", new DateTime(28 / 10 / 2021), new DateTime(13 / 08 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Keaton", "ac", "54678364", new DateTime(05 / 12 / 2021), new Pasaporte("WQU74GFO6XA", "Nigeria", new DateTime(11 / 04 / 2023), new DateTime(26 / 01 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Ivory", "Mauris", "33962187", new DateTime(06 / 10 / 2022), new Pasaporte("LNU61NCE9FM", "Ukraine", new DateTime(10 / 03 / 2023), new DateTime(25 / 08 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Marsden", "sit", "21506284", new DateTime(01 / 01 / 2022), new Pasaporte("MVK13IKB5VE", "Australia", new DateTime(30 / 11 / 2022), new DateTime(19 / 12 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Steel", "lorem", "29961881", new DateTime(21 / 04 / 2023), new Pasaporte("XVB21VMC2CS", "Ukraine", new DateTime(13 / 03 / 2023), new DateTime(12 / 11 / 2021)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Perry", "tellus", "44098644", new DateTime(13 / 02 / 2023), new Pasaporte("IJB81YEM2QG", "Peru", new DateTime(22 / 07 / 2023), new DateTime(29 / 01 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Maxine", "Ut", "42334909", new DateTime(02 / 07 / 2023), new Pasaporte("QEA24JST2OK", "Germany", new DateTime(22 / 03 / 2022), new DateTime(26 / 04 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Maggy", "rutrum.", "5320528", new DateTime(12 / 09 / 2022), new Pasaporte("DSD53DUC6PQ", "Russian Federation", new DateTime(07 / 02 / 2022), new DateTime(09 / 05 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Tobias", "sit", "38108776", new DateTime(22 / 01 / 2022), new Pasaporte("XDT87JYX4NS", "Brazil", new DateTime(09 / 02 / 2023), new DateTime(28 / 06 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Plato", "in", "9606585", new DateTime(25 / 09 / 2023), new Pasaporte("KMB71JUX8CQ", "Peru", new DateTime(11 / 10 / 2021), new DateTime(08 / 04 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Erich", "magna,", "30747032", new DateTime(08 / 08 / 2022), new Pasaporte("FSA09QUU4JY", "Norway", new DateTime(01 / 11 / 2021), new DateTime(08 / 08 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Troy", "mollis.", "31340754", new DateTime(02 / 11 / 2022), new Pasaporte("JZU75WHI5ML", "Mexico", new DateTime(11 / 12 / 2021), new DateTime(11 / 01 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Vance", "et,", "27013904", new DateTime(03 / 12 / 2022), new Pasaporte("SNG27EKG7LR", "Italy", new DateTime(12 / 11 / 2021), new DateTime(26 / 05 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Ignacia", "blandit", "51280994", new DateTime(22 / 02 / 2022), new Pasaporte("GVO37QKI8BV", "Netherlands", new DateTime(05 / 06 / 2022), new DateTime(12 / 02 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Cathleen", "nulla", "58382183", new DateTime(15 / 01 / 2023), new Pasaporte("ULW09HDM7TS", "Philippines", new DateTime(23 / 04 / 2023), new DateTime(23 / 07 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Acton", "in,", "27084759", new DateTime(27 / 05 / 2022), new Pasaporte("IBD73VEP1KP", "Netherlands", new DateTime(15 / 06 / 2023), new DateTime(20 / 04 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Edan", "orci", "15374060", new DateTime(02 / 09 / 2022), new Pasaporte("XGS82GLS6LF", "Australia", new DateTime(23 / 06 / 2022), new DateTime(16 / 07 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Lynn", "mauris", "38298406", new DateTime(27 / 04 / 2023), new Pasaporte("KQQ28QIE3SI", "France", new DateTime(03 / 09 / 2022), new DateTime(25 / 09 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Ifeoma", "nibh.", "37195238", new DateTime(18 / 08 / 2022), new Pasaporte("QDI17OSA5SD", "Ukraine", new DateTime(29 / 10 / 2021), new DateTime(24 / 06 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Ferris", "eu", "14309381", new DateTime(08 / 04 / 2023), new Pasaporte("ENC27PXI7NJ", "Philippines", new DateTime(23 / 05 / 2022), new DateTime(09 / 11 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Tashya", "mauris", "58185645", new DateTime(23 / 09 / 2023), new Pasaporte("ELI71EPS6RO", "Mexico", new DateTime(03 / 01 / 2023), new DateTime(14 / 06 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Jena", "arcu.", "2981976", new DateTime(30 / 07 / 2023), new Pasaporte("GOX43BOI5OI", "Russian Federation", new DateTime(12 / 08 / 2022), new DateTime(20 / 07 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Tobias", "dolor", "19202914", new DateTime(28 / 11 / 2022), new Pasaporte("FLB36YBS4HV", "Netherlands", new DateTime(28 / 01 / 2022), new DateTime(10 / 05 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Stuart", "lacus", "5977338", new DateTime(14 / 04 / 2023), new Pasaporte("ING44TUT5XZ", "Peru", new DateTime(17 / 11 / 2022), new DateTime(25 / 06 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Daquan", "lacus.", "42794174", new DateTime(27 / 09 / 2023), new Pasaporte("JET75TMU0YC", "Belgium", new DateTime(07 / 05 / 2023), new DateTime(03 / 01 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Vaughan", "Morbi", "55018156", new DateTime(06 / 10 / 2021), new Pasaporte("WTW67PNN8QL", "Pakistan", new DateTime(12 / 08 / 2022), new DateTime(11 / 01 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Regan", "sed", "56667585", new DateTime(16 / 02 / 2022), new Pasaporte("NPE45MJS5YV", "France", new DateTime(09 / 03 / 2023), new DateTime(15 / 02 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Paki", "porttitor", "16915168", new DateTime(27 / 08 / 2023), new Pasaporte("KFY91TFM3TL", "Italy", new DateTime(01 / 06 / 2023), new DateTime(14 / 06 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Abraham", "blandit", "57324140", new DateTime(13 / 01 / 2023), new Pasaporte("QDF26EIW4YF", "Belgium", new DateTime(16 / 11 / 2021), new DateTime(25 / 06 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Joan", "Fusce", "53479357", new DateTime(06 / 06 / 2023), new Pasaporte("GJG71IEJ1VM", "New Zealand", new DateTime(24 / 12 / 2022), new DateTime(30 / 06 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Mechelle", "enim.", "33119923", new DateTime(14 / 07 / 2023), new Pasaporte("JYN39WXY3SQ", "France", new DateTime(11 / 11 / 2022), new DateTime(29 / 03 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Uriel", "consequat", "50124630", new DateTime(16 / 03 / 2022), new Pasaporte("UEV95JNO1CF", "Austria", new DateTime(29 / 01 / 2023), new DateTime(06 / 01 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Rebecca", "purus.", "2752545", new DateTime(20 / 09 / 2023), new Pasaporte("CKG70PTN4JW", "Colombia", new DateTime(10 / 05 / 2023), new DateTime(07 / 08 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Dieter", "Fusce", "24401", new DateTime(26 / 08 / 2022), new Pasaporte("BGM75LUD4OI", "Poland", new DateTime(09 / 02 / 2022), new DateTime(29 / 11 / 2021)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Demetrius", "nibh", "23715675", new DateTime(19 / 04 / 2023), new Pasaporte("YOH67ZLW4UE", "Colombia", new DateTime(20 / 10 / 2022), new DateTime(24 / 02 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Shoshana", "litora", "16286578", new DateTime(10 / 10 / 2021), new Pasaporte("WTE79CII8TC", "Mexico", new DateTime(01 / 12 / 2021), new DateTime(07 / 10 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Macey", "nisi", "14829486", new DateTime(01 / 12 / 2021), new Pasaporte("MNU33AIH2CD", "Chile", new DateTime(26 / 07 / 2023), new DateTime(24 / 12 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Gail", "ipsum", "22998782", new DateTime(06 / 10 / 2021), new Pasaporte("BJD87LMQ3HY", "United Kingdom", new DateTime(22 / 06 / 2022), new DateTime(06 / 06 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Jocelyn", "Nam", "52925033", new DateTime(08 / 12 / 2022), new Pasaporte("SQJ67YTS4JV", "Nigeria", new DateTime(26 / 01 / 2023), new DateTime(06 / 10 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Gwendolyn", "porttitor", "40564760", new DateTime(23 / 08 / 2022), new Pasaporte("AHP93MWN4XJ", "Peru", new DateTime(28 / 03 / 2023), new DateTime(10 / 09 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Aurelia", "Nam", "39982748", new DateTime(13 / 05 / 2023), new Pasaporte("WBG86RSS4NI", "Poland", new DateTime(12 / 01 / 2022), new DateTime(03 / 04 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Tashya", "non,", "28750134", new DateTime(10 / 03 / 2023), new Pasaporte("QWQ65OEN4EE", "Costa Rica", new DateTime(03 / 02 / 2022), new DateTime(22 / 03 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Stone", "risus", "47234327", new DateTime(16 / 02 / 2023), new Pasaporte("IVX54CVI4BI", "New Zealand", new DateTime(02 / 03 / 2023), new DateTime(28 / 04 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Galvin", "non,", "54973936", new DateTime(03 / 02 / 2022), new Pasaporte("XWA27SIC4WE", "Peru", new DateTime(27 / 10 / 2022), new DateTime(06 / 02 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Robin", "amet", "37593882", new DateTime(31 / 05 / 2022), new Pasaporte("HGD44SUS7TU", "Norway", new DateTime(11 / 05 / 2023), new DateTime(30 / 05 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Larissa", "iaculis", "5986265", new DateTime(07 / 08 / 2023), new Pasaporte("QRD99TXV1IN", "Poland", new DateTime(20 / 03 / 2022), new DateTime(14 / 09 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Gary", "Phasellus", "56335794", new DateTime(11 / 01 / 2023), new Pasaporte("VIP85YGF0KW", "Germany", new DateTime(31 / 03 / 2023), new DateTime(16 / 12 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Bertha", "at,", "39696986", new DateTime(22 / 12 / 2021), new Pasaporte("VWN19XTH2XO", "Norway", new DateTime(17 / 03 / 2022), new DateTime(11 / 04 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Keith", "amet", "35156915", new DateTime(28 / 09 / 2023), new Pasaporte("USV47LDH1KV", "South Korea", new DateTime(18 / 06 / 2023), new DateTime(06 / 04 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Reed", "vel", "4100833", new DateTime(29 / 08 / 2022), new Pasaporte("BEP24MJS6LB", "China", new DateTime(08 / 11 / 2022), new DateTime(27 / 10 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Carlos", "at,", "31697836", new DateTime(25 / 08 / 2022), new Pasaporte("GEW77XHM7JQ", "Costa Rica", new DateTime(16 / 12 / 2022), new DateTime(28 / 09 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Rhonda", "sapien.", "30379795", new DateTime(17 / 03 / 2022), new Pasaporte("IEY81TIZ8FV", "Belgium", new DateTime(23 / 12 / 2022), new DateTime(19 / 02 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Cruz", "amet", "23515852", new DateTime(27 / 03 / 2022), new Pasaporte("BJE68UER4VS", "Sweden", new DateTime(17 / 09 / 2023), new DateTime(06 / 06 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Bianca", "enim.", "578953", new DateTime(11 / 06 / 2023), new Pasaporte("BPV42OFG7KI", "South Africa", new DateTime(08 / 05 / 2022), new DateTime(05 / 11 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Gage", "at,", "15561641", new DateTime(31 / 05 / 2023), new Pasaporte("NDH77WIJ8OV", "United States", new DateTime(13 / 06 / 2023), new DateTime(05 / 11 / 2021)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Ishmael", "velit", "51236486", new DateTime(04 / 06 / 2023), new Pasaporte("KOV78YJT8DP", "Philippines", new DateTime(16 / 12 / 2022), new DateTime(25 / 07 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "September", "Sed", "36553832", new DateTime(29 / 08 / 2022), new Pasaporte("GTC94OPO1QB", "New Zealand", new DateTime(19 / 04 / 2022), new DateTime(25 / 04 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Dalton", "risus.", "8621413", new DateTime(29 / 07 / 2022), new Pasaporte("BSS67EVS0OS", "Pakistan", new DateTime(25 / 12 / 2022), new DateTime(03 / 02 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Harrison", "bibendum", "35416599", new DateTime(09 / 01 / 2022), new Pasaporte("ISM66UQX3ZG", "Indonesia", new DateTime(12 / 12 / 2022), new DateTime(12 / 03 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Derek", "Nunc", "46614521", new DateTime(01 / 08 / 2023), new Pasaporte("XZO21HTV1DD", "United Kingdom", new DateTime(15 / 11 / 2022), new DateTime(29 / 12 / 2021)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Axel", "eu,", "31940606", new DateTime(24 / 01 / 2023), new Pasaporte("IXE11EKY8XA", "China", new DateTime(27 / 07 / 2022), new DateTime(04 / 01 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Salvador", "amet", "10073055", new DateTime(11 / 11 / 2022), new Pasaporte("XTJ43WUD5EY", "Russian Federation", new DateTime(16 / 09 / 2022), new DateTime(27 / 02 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Mariam", "Quisque", "12702581", new DateTime(12 / 11 / 2022), new Pasaporte("LHG62FRB1PP", "South Africa", new DateTime(27 / 03 / 2022), new DateTime(29 / 11 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Colorado", "Proin", "19124301", new DateTime(08 / 07 / 2022), new Pasaporte("PST92XIT0PG", "Vietnam", new DateTime(31 / 07 / 2022), new DateTime(28 / 07 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Blossom", "Nulla", "31024442", new DateTime(03 / 08 / 2022), new Pasaporte("OBM42MGW3CV", "Norway", new DateTime(06 / 06 / 2022), new DateTime(03 / 07 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Miriam", "lacus.", "8245551", new DateTime(09 / 07 / 2023), new Pasaporte("NHO26CGO3BY", "Indonesia", new DateTime(04 / 06 / 2022), new DateTime(26 / 03 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Connor", "felis.", "10730485", new DateTime(11 / 09 / 2023), new Pasaporte("WSV79RIW4YF", "Poland", new DateTime(24 / 05 / 2023), new DateTime(30 / 11 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Orla", "hendrerit", "32381516", new DateTime(18 / 02 / 2023), new Pasaporte("OVH22QVW5WI", "Singapore", new DateTime(20 / 06 / 2023), new DateTime(30 / 09 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Thaddeus", "nec", "48841621", new DateTime(18 / 09 / 2022), new Pasaporte("SLF47DPM7FA", "Norway", new DateTime(21 / 04 / 2023), new DateTime(13 / 06 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Arsenio", "Integer", "17586872", new DateTime(23 / 04 / 2022), new Pasaporte("YML28QWO6ZL", "Austria", new DateTime(03 / 03 / 2023), new DateTime(21 / 11 / 2021)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Phoebe", "lobortis", "1029530", new DateTime(02 / 06 / 2023), new Pasaporte("IJP13RYR3FE", "Germany", new DateTime(21 / 11 / 2022), new DateTime(24 / 09 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Jonas", "odio", "54303529", new DateTime(31 / 03 / 2023), new Pasaporte("IYT39XTF6MF", "Sweden", new DateTime(12 / 12 / 2021), new DateTime(31 / 12 / 2022)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Claudia", "at", "29556611", new DateTime(24 / 07 / 2023), new Pasaporte("EYC72RTR1CW", "Singapore", new DateTime(25 / 06 / 2022), new DateTime(26 / 06 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Xenos", "nisi", "59279166", new DateTime(10 / 08 / 2022), new Pasaporte("XSA44PUE2SJ", "Belgium", new DateTime(20 / 09 / 2022), new DateTime(17 / 08 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Robert", "fringilla", "48220851", new DateTime(07 / 10 / 2022), new Pasaporte("PWW89CFL8HM", "Philippines", new DateTime(11 / 06 / 2022), new DateTime(07 / 09 / 2023)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Illiana", "tincidunt.", "38360580", new DateTime(25 / 05 / 2023), new Pasaporte("WDH94CQP4NH", "Vietnam", new DateTime(30 / 06 / 2022), new DateTime(20 / 01 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Idona", "convallis", "29538580", new DateTime(14 / 03 / 2022), new Pasaporte("YCR87ROO1HP", "Pakistan", new DateTime(28 / 02 / 2022), new DateTime(04 / 06 / 2023)), true));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Keegan", "vitae", "8381993", new DateTime(22 / 03 / 2023), new Pasaporte("KTR56IDX7CI", "Canada", new DateTime(12 / 12 / 2021), new DateTime(26 / 03 / 2022)), false));
            Hardcodeo.listaP1.Add(new Pasajero(true, "Dustin", "auctor.", "51052615", new DateTime(10 / 03 / 2022), new Pasaporte("KXS13LFJ3LC", "Ukraine", new DateTime(06 / 02 / 2022), new DateTime(02 / 06 / 2022)), false));

            Hardcodeo.AgregarPasajerosHardcodeadosAViaje();
        }

        #endregion

        private static void AgregarPasajerosHardcodeadosAViaje()
        {
            int i;
            foreach (Pasajero pasajeroItem in Hardcodeo.listaP1)
            {
                for (i = 0; i < Hardcodeo.listaViajes.Count; i++)
                {
                    Hardcodeo.listaViajes[i] = Hardcodeo.listaViajes[i] + pasajeroItem;
                }
            }
        }

    }
}
