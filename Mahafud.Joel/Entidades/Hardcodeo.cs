using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Hardcodeo
    {
        #region Atributos estáticos
        private static List<Operario> listaOperarios;
        private static List<Crucero> listaCruceros;
        private static List<Viaje> listaViajesActuales;
        private static List<Viaje> listaViajesHistoricos;
        private static List<Pasajero> listaPasajeros;
        #endregion

        #region Constructor estático
        static Hardcodeo()
        {
            Hardcodeo.listaOperarios = new List<Operario>();
            Hardcodeo.listaCruceros = new List<Crucero>();
            Hardcodeo.listaViajesActuales = new List<Viaje>();
            Hardcodeo.listaViajesHistoricos = new List<Viaje>();
            Hardcodeo.listaPasajeros = new List<Pasajero>();

            Hardcodeo.InicializarOperariosHardcodeados();
            Hardcodeo.InicializarCrucerosHardcodeados();
            Hardcodeo.InicializarPasajerosHardcodeados();
            Hardcodeo.InicializarViajesHistoricosHardcodeados();
            Hardcodeo.InicializarViajesHardcodeados();
        }
        #endregion

        #region Propiedades estáticas
        public static List<Operario> ListaOperarios 
        { 
            get { return Hardcodeo.listaOperarios; } 
            //set { }
        }

        public static List<Crucero> ListaCruceros 
        { 
            get { return Hardcodeo.listaCruceros; }
            //set { } 
        }

        public static List<Viaje> ListaViajesActuales
        {
            get { return Hardcodeo.listaViajesActuales; }
            set { Hardcodeo.ListaViajesActuales = value; }
        }

        public static List<Viaje> ListaViajesHistoricos
        {
            get { return Hardcodeo.listaViajesHistoricos; }
            //set { }
        }
        #endregion

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
            Crucero c1 = new Crucero(50, "AA111000", "La Cumbancha Volante", 0, 1, 2, 1250);
            Crucero c2 = new Crucero(100, "BB222000", "Titanic II", 4, 0, 6, 2500);
            Crucero c3 = new Crucero(1000, "CC333000", "The Luxury Placeholder", 12, 6, 10, 10000);
            Crucero c4 = new Crucero(120, "DD444000", "The Wanderer", 0, 3, 3, 2700);
            Crucero c5 = new Crucero(300, "EE555000", "Tom Cruiser", 2, 0, 4, 3200);
            Crucero c6 = new Crucero(200, "FF666000", "Poseidón", 1, 1, 3, 4000);
            Crucero c7 = new Crucero(10, "GG777000", "El Odiseo", 0, 0, 1, 300);

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

            Hardcodeo.listaViajesActuales.Add(v1);
            Hardcodeo.listaViajesActuales.Add(v2);
            Hardcodeo.listaViajesActuales.Add(v3);
            Hardcodeo.listaViajesActuales.Add(v4);
            Hardcodeo.listaViajesActuales.Add(v5);
            Hardcodeo.listaViajesActuales.Add(v6);
            Hardcodeo.listaViajesActuales.Add(v7);

            Hardcodeo.listaViajesHistoricos.Add(v1);
            Hardcodeo.listaViajesHistoricos.Add(v2);
            Hardcodeo.listaViajesHistoricos.Add(v3);
            Hardcodeo.listaViajesHistoricos.Add(v4);
            Hardcodeo.listaViajesHistoricos.Add(v5);
            Hardcodeo.listaViajesHistoricos.Add(v6);
            Hardcodeo.listaViajesHistoricos.Add(v7);

            AgregarPasajerosHardcodeadosAViaje(Hardcodeo.listaViajesActuales);
        }
        #endregion

        #region Hardcodeo de Viajes Historicos
        private static void InicializarViajesHistoricosHardcodeados()
        {
            DateTime auxDT = DateTime.Today.AddDays(-180);

            Viaje v1 = new Viaje(auxDT.AddDays(1).AddHours(15), Hardcodeo.listaCruceros[0], EDestino.Bangkok);
            Viaje v2 = new Viaje(auxDT.AddDays(110).AddHours(13), Hardcodeo.listaCruceros[1], EDestino.Cartagena);
            Viaje v3 = new Viaje(auxDT.AddDays(95).AddHours(21), Hardcodeo.listaCruceros[2], EDestino.IslaGalapagos);
            Viaje v4 = new Viaje(auxDT.AddDays(86).AddHours(8), Hardcodeo.listaCruceros[3], EDestino.Lima);
            Viaje v5 = new Viaje(auxDT.AddDays(168).AddHours(11), Hardcodeo.listaCruceros[4], EDestino.Miami);
            Viaje v6 = new Viaje(auxDT.AddDays(5).AddHours(16), Hardcodeo.listaCruceros[5], EDestino.Venecia);
            Viaje v7 = new Viaje(auxDT.AddDays(27).AddHours(17), Hardcodeo.listaCruceros[6], EDestino.RioDeJaneiro);
            Viaje v8 = new Viaje(auxDT.AddDays(77).AddHours(6), Hardcodeo.listaCruceros[4], EDestino.Ushuaia);
            Viaje v9 = new Viaje(auxDT.AddDays(106).AddHours(14), Hardcodeo.listaCruceros[0], EDestino.Santiago);
            Viaje v10 = new Viaje(auxDT.AddDays(43).AddHours(19), Hardcodeo.listaCruceros[6], EDestino.LaHabana);
            Viaje v11 = new Viaje(auxDT.AddDays(69).AddHours(20), Hardcodeo.listaCruceros[5], EDestino.Acapulco);

            Hardcodeo.listaViajesHistoricos.Add(v1);
            Hardcodeo.listaViajesHistoricos.Add(v2);
            Hardcodeo.listaViajesHistoricos.Add(v3);
            Hardcodeo.listaViajesHistoricos.Add(v4);
            Hardcodeo.listaViajesHistoricos.Add(v5);
            Hardcodeo.listaViajesHistoricos.Add(v6);
            Hardcodeo.listaViajesHistoricos.Add(v7); 
            Hardcodeo.listaViajesHistoricos.Add(v8);
            Hardcodeo.listaViajesHistoricos.Add(v9);
            Hardcodeo.listaViajesHistoricos.Add(v10);
            Hardcodeo.listaViajesHistoricos.Add(v11);

            AgregarPasajerosHardcodeadosAViaje(Hardcodeo.listaViajesHistoricos);
        }
        #endregion

        #region Hardcodeo de Pasajeros
        private static void InicializarPasajerosHardcodeados()
        {
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Perry", "Cantu", "21764354", new DateTime(1980, 04, 10), new Pasaporte("AAB67EBM1KR", "South Africa", new DateTime(2017, 03, 13), new DateTime(2026, 09, 06)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Emmanuel", "Owen", "48755935", new DateTime(1954, 01, 25), new Pasaporte("XHM37CYM2GN", "South Korea", new DateTime(2020, 05, 21), new DateTime(2025, 08, 07)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Cadman", "Berry", "49124518", new DateTime(1962, 03, 29), new Pasaporte("JKO58QON3TG", "Italy", new DateTime(2013, 06, 09), new DateTime(2027, 09, 25)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Imelda", "Cardenas", "46263942", new DateTime(1957, 02, 10), new Pasaporte("AXI66OKB4QI", "Colombia", new DateTime(2015, 01, 01), new DateTime(2028, 10, 18)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Connor", "Cleveland", "3061807", new DateTime(1942, 01, 28), new Pasaporte("HWY06WBL9NT", "Brazil", new DateTime(2018, 09, 13), new DateTime(2026, 09, 14)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Leo", "Hahn", "13360396", new DateTime(1996, 09, 20), new Pasaporte("YOD12XUL5EQ", "Colombia", new DateTime(2014, 01, 11), new DateTime(2023, 08, 24)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Gareth", "Thomas", "36373787", new DateTime(1989, 03, 03), new Pasaporte("DHT24MNK0IR", "South Africa", new DateTime(2017, 08, 13), new DateTime(2023, 09, 21)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Jonas", "Kinney", "25919249", new DateTime(1955, 03, 19), new Pasaporte("CES26RZZ7YD", "Philippines", new DateTime(2020, 05, 12), new DateTime(2029, 09, 04)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Jamal", "Welch", "48880425", new DateTime(1985, 04, 21), new Pasaporte("WVJ21WYX5VS", "Italy", new DateTime(2019, 09, 12), new DateTime(2029, 05, 02)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Lucius", "Roberts", "55022478", new DateTime(1983, 12, 15), new Pasaporte("JQL25SQK6OP", "Colombia", new DateTime(2016, 06, 19), new DateTime(2026, 07, 25)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Kadeem", "Adkins", "22355879", new DateTime(1986, 06, 15), new Pasaporte("JWR62JVE8ON", "Russian Federation", new DateTime(2018, 07, 29), new DateTime(2026, 02, 02)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Dennis", "Holmes", "25892988", new DateTime(1961, 02, 05), new Pasaporte("FXD47RDD7OS", "Mexico", new DateTime(2017, 04, 04), new DateTime(2024, 04, 26)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Halla", "Garner", "26685519", new DateTime(1983, 05, 22), new Pasaporte("IXF26LGL5LU", "Singapore", new DateTime(2012, 12, 31), new DateTime(2029, 10, 24)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Dorothy", "Koch", "4876338", new DateTime(1933, 12, 30), new Pasaporte("XVK76YLN6UN", "Russian Federation", new DateTime(2022, 01, 22), new DateTime(2025, 10, 08)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "David", "Pacheco", "50148051", new DateTime(2015, 08, 29), new Pasaporte("HWA12KWL4PU", "Russian Federation", new DateTime(2018, 01, 19), new DateTime(2031, 10, 01)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Holly", "Reilly", "27734009", new DateTime(2003, 01, 06), new Pasaporte("VBS01WXM1CG", "Chile", new DateTime(2015, 11, 05), new DateTime(2025, 06, 23)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Nomlanga", "Guerrero", "22281024", new DateTime(1967, 12, 27), new Pasaporte("WHO80EXG7XK", "Costa Rica", new DateTime(2017, 06, 22), new DateTime(2025, 03, 23)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Quyn", "Fitzpatrick", "30703345", new DateTime(1936, 04, 16), new Pasaporte("TGR79KQF5MF", "Colombia", new DateTime(2021, 06, 28), new DateTime(2029, 09, 09)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Avye", "Hawkins", "16328365", new DateTime(1960, 10, 16), new Pasaporte("WFI55NXG7RP", "Italy", new DateTime(2015, 12, 29), new DateTime(2030, 11, 23)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Knox", "Greer", "33643739", new DateTime(2011, 09, 01), new Pasaporte("WWE68NRE0EI", "United States", new DateTime(2016, 11, 29), new DateTime(2028, 07, 18)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Damian", "Hatfield", "35343382", new DateTime(1931, 01, 14), new Pasaporte("WDX86JRP8KX", "Russian Federation", new DateTime(2017, 04, 17), new DateTime(2025, 11, 23)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Quentin", "Schroeder", "27037575", new DateTime(1932, 06, 28), new Pasaporte("CXE78WCP0VW", "Brazil", new DateTime(2016, 11, 03), new DateTime(2031, 01, 07)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Keaton", "Walters", "54678364", new DateTime(2008, 08, 19), new Pasaporte("WQU74GFO6XA", "Nigeria", new DateTime(2017, 12, 13), new DateTime(2025, 06, 03)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Ivory", "Witt", "33962187", new DateTime(2004, 09, 05), new Pasaporte("LNU61NCE9FM", "Ukraine", new DateTime(2016, 06, 15), new DateTime(2032, 03, 25)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Marsden", "Mcintyre", "21506284", new DateTime(2016, 05, 29), new Pasaporte("MVK13IKB5VE", "Australia", new DateTime(2012, 11, 25), new DateTime(2024, 06, 27)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Steel", "Garcia", "29961881", new DateTime(1948, 10, 09), new Pasaporte("XVB21VMC2CS", "Ukraine", new DateTime(2020, 11, 13), new DateTime(2030, 01, 12)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Perry", "Burgess", "44098644", new DateTime(1990, 01, 07), new Pasaporte("IJB81YEM2QG", "Peru", new DateTime(2017, 04, 12), new DateTime(2028, 03, 17)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Maxine", "Clemons", "42334909", new DateTime(1955, 03, 22), new Pasaporte("QEA24JST2OK", "Germany", new DateTime(2021, 06, 13), new DateTime(2026, 04, 09)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Maggy", "Gibson", "5320528", new DateTime(2019, 06, 27), new Pasaporte("DSD53DUC6PQ", "Russian Federation", new DateTime(2022, 02, 08), new DateTime(2032, 07, 08)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Tobias", "Buckner", "38108776", new DateTime(1954, 04, 07), new Pasaporte("XDT87JYX4NS", "Brazil", new DateTime(2017, 02, 04), new DateTime(2032, 04, 05)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Plato", "Mayo", "9606585", new DateTime(1950, 10, 26), new Pasaporte("KMB71JUX8CQ", "Peru", new DateTime(2021, 03, 26), new DateTime(2027, 06, 17)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Erich", "Huffman", "30747032", new DateTime(2009, 09, 26), new Pasaporte("FSA09QUU4JY", "Norway", new DateTime(2017, 07, 15), new DateTime(2031, 06, 16)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Troy", "Battle", "31340754", new DateTime(1995, 06, 01), new Pasaporte("JZU75WHI5ML", "Mexico", new DateTime(2018, 05, 25), new DateTime(2024, 02, 19)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Vance", "Francis", "27013904", new DateTime(1946, 07, 27), new Pasaporte("SNG27EKG7LR", "Italy", new DateTime(2017, 06, 10), new DateTime(2032, 01, 06)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Ignacia", "Hardy", "51280994", new DateTime(1922, 05, 04), new Pasaporte("GVO37QKI8BV", "Netherlands", new DateTime(2014, 12, 01), new DateTime(2029, 07, 23)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Cathleen", "Acosta", "58382183", new DateTime(2006, 12, 19), new Pasaporte("ULW09HDM7TS", "Philippines", new DateTime(2017, 12, 31), new DateTime(2028, 01, 14)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Acton", "Gallagher", "27084759", new DateTime(1974, 03, 14), new Pasaporte("IBD73VEP1KP", "Netherlands", new DateTime(2015, 08, 05), new DateTime(2029, 02, 10)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Edan", "Graham", "15374060", new DateTime(1986, 06, 08), new Pasaporte("XGS82GLS6LF", "Australia", new DateTime(2020, 07, 30), new DateTime(2028, 07, 29)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Lynn", "Young", "38298406", new DateTime(1956, 04, 02), new Pasaporte("KQQ28QIE3SI", "France", new DateTime(2021, 07, 10), new DateTime(2030, 07, 09)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Ifeoma", "Decker", "37195238", new DateTime(1954, 02, 05), new Pasaporte("QDI17OSA5SD", "Ukraine", new DateTime(2016, 12, 24), new DateTime(2029, 10, 13)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Ferris", "Walton", "14309381", new DateTime(1934, 04, 21), new Pasaporte("ENC27PXI7NJ", "Philippines", new DateTime(2015, 02, 28), new DateTime(2026, 09, 28)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Tashya", "Johnson", "58185645", new DateTime(2003, 08, 04), new Pasaporte("ELI71EPS6RO", "Mexico", new DateTime(2022, 04, 22), new DateTime(2030, 10, 31)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Jena", "Gregory", "2981976", new DateTime(2018, 11, 29), new Pasaporte("GOX43BOI5OI", "Russian Federation", new DateTime(2018, 12, 02), new DateTime(2026, 04, 14)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Tobias", "Yang", "19202914", new DateTime(2018, 09, 16), new Pasaporte("FLB36YBS4HV", "Netherlands", new DateTime(2019, 01, 08), new DateTime(2032, 07, 21)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Stuart", "Phillips", "5977338", new DateTime(1981, 01, 24), new Pasaporte("ING44TUT5XZ", "Peru", new DateTime(2021, 10, 14), new DateTime(2023, 03, 31)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Daquan", "Callahan", "42794174", new DateTime(1998, 11, 16), new Pasaporte("JET75TMU0YC", "Belgium", new DateTime(2016, 07, 31), new DateTime(2032, 03, 08)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Vaughan", "Sandoval", "55018156", new DateTime(2002, 11, 08), new Pasaporte("WTW67PNN8QL", "Pakistan", new DateTime(2015, 01, 17), new DateTime(2030, 05, 09)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Regan", "Alexander", "56667585", new DateTime(1969, 02, 07), new Pasaporte("NPE45MJS5YV", "France", new DateTime(2013, 09, 04), new DateTime(2031, 04, 14)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Paki", "Emerson", "16915168", new DateTime(2012, 09, 29), new Pasaporte("KFY91TFM3TL", "Italy", new DateTime(2021, 02, 15), new DateTime(2024, 11, 01)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Abraham", "Mcgee", "57324140", new DateTime(1944, 09, 12), new Pasaporte("QDF26EIW4YF", "Belgium", new DateTime(2020, 06, 18), new DateTime(2029, 01, 01)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Joan", "Johns", "53479357", new DateTime(1932, 06, 14), new Pasaporte("GJG71IEJ1VM", "New Zealand", new DateTime(2016, 12, 25), new DateTime(2025, 07, 06)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Mechelle", "Ortega", "33119923", new DateTime(1970, 03, 27), new Pasaporte("JYN39WXY3SQ", "France", new DateTime(2017, 02, 28), new DateTime(2031, 12, 02)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Uriel", "Merritt", "50124630", new DateTime(2000, 08, 30), new Pasaporte("UEV95JNO1CF", "Austria", new DateTime(2014, 10, 13), new DateTime(2027, 05, 20)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Rebecca", "Conley", "2752545", new DateTime(1979, 05, 27), new Pasaporte("CKG70PTN4JW", "Colombia", new DateTime(2018, 01, 17), new DateTime(2026, 08, 03)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Dieter", "Coffey", "24401", new DateTime(1937, 12, 10), new Pasaporte("BGM75LUD4OI", "Poland", new DateTime(2021, 08, 06), new DateTime(2029, 11, 05)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Demetrius", "Good", "23715675", new DateTime(1949, 02, 20), new Pasaporte("YOH67ZLW4UE", "Colombia", new DateTime(2015, 05, 29), new DateTime(2032, 08, 17)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Shoshana", "Pace", "16286578", new DateTime(2013, 04, 13), new Pasaporte("WTE79CII8TC", "Mexico", new DateTime(2016, 03, 05), new DateTime(2028, 11, 03)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Macey", "Lamb", "14829486", new DateTime(1927, 07, 30), new Pasaporte("MNU33AIH2CD", "Chile", new DateTime(2013, 05, 30), new DateTime(2030, 09, 20)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Gail", "Holmes", "22998782", new DateTime(1955, 01, 16), new Pasaporte("BJD87LMQ3HY", "United Kingdom", new DateTime(2013, 11, 15), new DateTime(2023, 10, 30)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Jocelyn", "Olson", "52925033", new DateTime(2007, 10, 05), new Pasaporte("SQJ67YTS4JV", "Nigeria", new DateTime(2019, 10, 12), new DateTime(2028, 07, 19)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Gwendolyn", "Ortega", "40564760", new DateTime(1950, 08, 14), new Pasaporte("AHP93MWN4XJ", "Peru", new DateTime(2019, 11, 06), new DateTime(2029, 11, 20)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Aurelia", "Gill", "39982748", new DateTime(1950, 11, 14), new Pasaporte("WBG86RSS4NI", "Poland", new DateTime(2020, 07, 31), new DateTime(2026, 10, 02)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Tashya", "Wynn", "28750134", new DateTime(2013, 03, 09), new Pasaporte("QWQ65OEN4EE", "Costa Rica", new DateTime(2018, 06, 10), new DateTime(2024, 03, 02)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Stone", "Knapp", "47234327", new DateTime(2007, 04, 06), new Pasaporte("IVX54CVI4BI", "New Zealand", new DateTime(2018, 02, 07), new DateTime(2024, 04, 06)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Galvin", "Patton", "54973936", new DateTime(2020, 04, 28), new Pasaporte("XWA27SIC4WE", "Peru", new DateTime(2014, 06, 10), new DateTime(2031, 07, 21)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Robin", "Conrad", "37593882", new DateTime(2003, 07, 07), new Pasaporte("HGD44SUS7TU", "Norway", new DateTime(2015, 04, 05), new DateTime(2027, 11, 29)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Larissa", "Howe", "5986265", new DateTime(1935, 05, 28), new Pasaporte("QRD99TXV1IN", "Poland", new DateTime(2017, 04, 29), new DateTime(2024, 04, 27)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Gary", "Dodson", "56335794", new DateTime(1951, 06, 07), new Pasaporte("VIP85YGF0KW", "Germany", new DateTime(2016, 09, 06), new DateTime(2030, 11, 19)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Bertha", "Rush", "39696986", new DateTime(1951, 02, 03), new Pasaporte("VWN19XTH2XO", "Norway", new DateTime(2022, 08, 07), new DateTime(2027, 07, 02)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Keith", "Le", "35156915", new DateTime(1926, 05, 18), new Pasaporte("USV47LDH1KV", "South Korea", new DateTime(2022, 06, 07), new DateTime(2031, 11, 24)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Reed", "Rich", "4100833", new DateTime(2014, 04, 08), new Pasaporte("BEP24MJS6LB", "China", new DateTime(2020, 06, 22), new DateTime(2028, 01, 07)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Carlos", "Gilliam", "31697836", new DateTime(2012, 05, 13), new Pasaporte("GEW77XHM7JQ", "Costa Rica", new DateTime(2013, 06, 15), new DateTime(2025, 05, 24)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Rhonda", "Wade", "30379795", new DateTime(1935, 05, 21), new Pasaporte("IEY81TIZ8FV", "Belgium", new DateTime(2019, 12, 29), new DateTime(2023, 05, 02)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Cruz", "Wagner", "23515852", new DateTime(1963, 04, 04), new Pasaporte("BJE68UER4VS", "Sweden", new DateTime(2013, 01, 14), new DateTime(2027, 05, 05)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Bianca", "Hickman", "578953", new DateTime(2001, 05, 25), new Pasaporte("BPV42OFG7KI", "South Africa", new DateTime(2021, 07, 30), new DateTime(2024, 12, 04)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Gage", "Patrick", "15561641", new DateTime(2007, 11, 15), new Pasaporte("NDH77WIJ8OV", "United States", new DateTime(2015, 10, 16), new DateTime(2030, 02, 20)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Ishmael", "Martinez", "51236486", new DateTime(2015, 09, 04), new Pasaporte("KOV78YJT8DP", "Philippines", new DateTime(2017, 03, 01), new DateTime(2027, 02, 03)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "September", "Morse", "36553832", new DateTime(1979, 05, 03), new Pasaporte("GTC94OPO1QB", "New Zealand", new DateTime(2019, 07, 28), new DateTime(2025, 09, 23)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Dalton", "Dillon", "8621413", new DateTime(1927, 09, 25), new Pasaporte("BSS67EVS0OS", "Pakistan", new DateTime(2019, 03, 26), new DateTime(2023, 07, 03)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Harrison", "Barton", "35416599", new DateTime(2012, 02, 12), new Pasaporte("ISM66UQX3ZG", "Indonesia", new DateTime(2020, 07, 22), new DateTime(2029, 09, 15)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Derek", "Mendez", "46614521", new DateTime(2013, 02, 23), new Pasaporte("XZO21HTV1DD", "United Kingdom", new DateTime(2017, 09, 16), new DateTime(2028, 12, 01)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Axel", "Solomon", "31940606", new DateTime(2019, 09, 09), new Pasaporte("IXE11EKY8XA", "China", new DateTime(2013, 10, 08), new DateTime(2025, 07, 06)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Salvador", "Tate", "10073055", new DateTime(1960, 10, 08), new Pasaporte("XTJ43WUD5EY", "Russian Federation", new DateTime(2013, 11, 07), new DateTime(2025, 12, 11)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Mariam", "Duran", "12702581", new DateTime(1967, 07, 09), new Pasaporte("LHG62FRB1PP", "South Africa", new DateTime(2016, 05, 14), new DateTime(2032, 01, 21)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Colorado", "Fisher", "19124301", new DateTime(2010, 06, 11), new Pasaporte("PST92XIT0PG", "Vietnam", new DateTime(2017, 09, 10), new DateTime(2024, 07, 02)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Blossom", "Barr", "31024442", new DateTime(2004, 02, 13), new Pasaporte("OBM42MGW3CV", "Norway", new DateTime(2017, 07, 08), new DateTime(2031, 08, 27)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Miriam", "Key", "8245551", new DateTime(1969, 01, 24), new Pasaporte("NHO26CGO3BY", "Indonesia", new DateTime(2012, 11, 24), new DateTime(2030, 03, 28)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Connor", "Frost", "10730485", new DateTime(1954, 09, 29), new Pasaporte("WSV79RIW4YF", "Poland", new DateTime(2015, 04, 28), new DateTime(2029, 08, 06)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Orla", "Delacruz", "32381516", new DateTime(2017, 08, 28), new Pasaporte("OVH22QVW5WI", "Singapore", new DateTime(2019, 08, 10), new DateTime(2029, 12, 31)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Thaddeus", "Ware", "48841621", new DateTime(2013, 01, 16), new Pasaporte("SLF47DPM7FA", "Norway", new DateTime(2021, 06, 06), new DateTime(2029, 07, 09)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Arsenio", "Underwood", "17586872", new DateTime(1979, 03, 04), new Pasaporte("YML28QWO6ZL", "Austria", new DateTime(2022, 02, 03), new DateTime(2030, 01, 05)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Phoebe", "Potts", "1029530", new DateTime(1977, 07, 02), new Pasaporte("IJP13RYR3FE", "Germany", new DateTime(2018, 01, 23), new DateTime(2028, 11, 25)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Jonas", "Dennis", "54303529", new DateTime(1944, 10, 28), new Pasaporte("IYT39XTF6MF", "Sweden", new DateTime(2017, 09, 12), new DateTime(2027, 07, 22)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Claudia", "Palmer", "29556611", new DateTime(1955, 03, 20), new Pasaporte("EYC72RTR1CW", "Singapore", new DateTime(2018, 06, 30), new DateTime(2031, 11, 23)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Xenos", "Jarvis", "59279166", new DateTime(1941, 01, 11), new Pasaporte("XSA44PUE2SJ", "Belgium", new DateTime(2019, 06, 18), new DateTime(2027, 05, 20)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Robert", "Rosario", "48220851", new DateTime(1931, 01, 10), new Pasaporte("PWW89CFL8HM", "Philippines", new DateTime(2021, 02, 12), new DateTime(2026, 09, 12)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Illiana", "Alford", "38360580", new DateTime(1964, 03, 15), new Pasaporte("WDH94CQP4NH", "Vietnam", new DateTime(2018, 07, 12), new DateTime(2028, 11, 26)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Idona", "Brennan", "29538580", new DateTime(1992, 05, 22), new Pasaporte("YCR87ROO1HP", "Pakistan", new DateTime(2018, 01, 27), new DateTime(2023, 01, 23)), true));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Keegan", "Knapp", "8381993", new DateTime(1978, 09, 10), new Pasaporte("KTR56IDX7CI", "Canada", new DateTime(2021, 05, 14), new DateTime(2028, 02, 23)), false));
            Hardcodeo.listaPasajeros.Add(new Pasajero(true, "Dustin", "Herrera", "51052615", new DateTime(1989, 01, 04), new Pasaporte("KXS13LFJ3LC", "Ukraine", new DateTime(2017, 01, 16), new DateTime(2025, 11, 19)), false));

        }
        #endregion

        #region Métodos estáticos
        private static void AgregarPasajerosHardcodeadosAViaje(List<Viaje> viajes)
        {
            int i;
            foreach (Pasajero pasajeroItem in Hardcodeo.listaPasajeros)
            {
                for (i = 0; i < viajes.Count; i++)
                {
                    viajes[i] = viajes[i] + pasajeroItem;
                }
            }
        }
        #endregion
    }
}