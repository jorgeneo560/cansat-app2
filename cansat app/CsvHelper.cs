using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using System.Timers;

namespace Cansat2021
{
    public class CsvHelper
    {
        public static void writeCsvFromList(List<string> telemetryList)
        {
            #region Option1
            if (!string.IsNullOrEmpty(telemetryList[3])) //si hay algún valor en la 4ta posición de la lista...
            {
                if (telemetryList[3] == "C")
                {
                    var records = new List<Container>
                    {
                        new Container {
                            TeamId = telemetryList[0],
                            MissionTime = telemetryList[1],
                            PacketCount = telemetryList[2],
                            PacketType = telemetryList[3],
                            Mode = telemetryList[4],
                            Sp1Released = telemetryList[5],
                            Sp2Released = telemetryList[6],
                            Altitude = telemetryList[7],
                            Temperature = telemetryList[8],
                            Voltage = telemetryList[9],
                            GpsTime = telemetryList[10],
                            GpsLatitude = telemetryList[11],
                            GpsLongitude = telemetryList[12],
                            GpsAltitude = telemetryList[13],
                            GpsSats = telemetryList[14],
                            SoftwareState = telemetryList[15],
                            Sp1PacketCount = telemetryList[16],
                            Sp2PacketCount = telemetryList[17],
                            CmdEcho = telemetryList[18]
                        }
                    };
                    string path = "C:\\Flight_1231_C.csv";
                    handleContainerFile(path, records);
                }
                else
                {
                    string path;
                    var records = new List<SciencePayload>
                    {
                        new SciencePayload
                        {
                            TeamId = telemetryList[0],
                            MissionTime = telemetryList[1],
                            PacketCount = telemetryList[2],
                            PacketType = telemetryList[3],
                            SpAltitude = telemetryList[4],
                            SpTemperature = telemetryList[5],
                            SpRotationRate = telemetryList[6]
                        }
                    };
                    path = telemetryList[3] == "SP1" ? "C:\\Flight_1231_SP1.csv" : "C:\\Flight_1231_SP2.csv";
                    handlePayloadFile(path, records);
                }
            }
            #endregion //cuando viene completo 12,265,155,,,,,,,,,,,

            #region Option2
            if (telemetryList.Count == 19)
            {
                var records = new List<Container>
                {
                    new Container {
                        TeamId = telemetryList[0],
                        MissionTime = telemetryList[1],
                        PacketCount = telemetryList[2],
                        PacketType = telemetryList[3],
                        Mode = telemetryList[4],
                        Sp1Released = telemetryList[5],
                        Sp2Released = telemetryList[6],
                        Altitude = telemetryList[7],
                        Temperature = telemetryList[8],
                        Voltage = telemetryList[9],
                        GpsTime = telemetryList[10],
                        GpsLatitude = telemetryList[11],
                        GpsLongitude = telemetryList[12],
                        GpsAltitude = telemetryList[13],
                        GpsSats = telemetryList[14],
                        SoftwareState = telemetryList[15],
                        Sp1PacketCount = telemetryList[16],
                        Sp2PacketCount = telemetryList[17],
                        CmdEcho = telemetryList[18]
                    }
                };
                string path = "C:\\Flight_1231_C.csv";
                handleContainerFile(path, records);
            }
            else if (telemetryList.Count == 7)
            {
                string path;
                var records = new List<SciencePayload>
                {
                    new SciencePayload
                    {
                        TeamId = telemetryList[0],
                        MissionTime = telemetryList[1],
                        PacketCount = telemetryList[2],
                        PacketType = telemetryList[3],
                        SpAltitude = telemetryList[4],
                        SpTemperature = telemetryList[5],
                        SpRotationRate = telemetryList[6]
                    }
                };
                path = telemetryList[3] == "SP1" ? "C:\\Flight_1231_SP1.csv" : "C:\\Flight_1231_SP2.csv";

                handlePayloadFile(path, records);
            }
            #endregion//

        }

        public class Container
        {
            public string TeamId { get; set; }
            public string MissionTime { get; set; }
            public string PacketCount { get; set; }
            public string PacketType { get; set; }
            public string Mode { get; set; }
            public string Sp1Released { get; set; }
            public string Sp2Released { get; set; }
            public string Altitude { get; set; }
            public string Temperature { get; set; }
            public string Voltage { get; set; }
            public string GpsTime { get; set; }
            public string GpsLatitude { get; set; }
            public string GpsLongitude { get; set; }
            public string GpsAltitude { get; set; }
            public string GpsSats { get; set; }
            public string SoftwareState { get; set; }
            public string Sp1PacketCount { get; set; }
            public string Sp2PacketCount { get; set; }
            public string CmdEcho { get; set; }

        }

        public class SciencePayload
        {
            public string TeamId { get; set; }
            public string MissionTime { get; set; }
            public string PacketCount { get; set; }
            public string PacketType { get; set; }
            public string SpAltitude { get; set; }
            public string SpTemperature { get; set; }
            public string SpRotationRate { get; set; }
        }

        private static void handleContainerFile(string path, List<Container> records)
        {
            if (!File.Exists(path))
            {
                var myFile = File.Create(path);
                myFile.Close();
            }
            var csvFileLenth = new FileInfo(path).Length;
            if (csvFileLenth == 0)
            {
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.NextRecord();
                    csv.WriteRecords(records);
                }
            }
            else
            {
                // Append to the file.
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(path, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }
            }
        }

        private static void handlePayloadFile(string path, List<SciencePayload> records)
        {
            if (!File.Exists(path))
            {
                var myFile = File.Create(path);
                myFile.Close();
            }
            var csvFileLenth = new FileInfo(path).Length;
            if (csvFileLenth == 0)
            {
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.NextRecord();
                    csv.WriteRecords(records);
                }
            }
            else
            {
                // Append to the file.
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(path, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }
            }
        }

        public string readExampleFile()
        {
            //var data = File.OpenRead(Server.MapPath("C:\\simp_cmd_example.txt"));
            //var FileAsString = data.ToString();
            //return FileAsString;
            var FileAsString = "";
            string path = "C:\\simp_cmd_example.txt";
            if (File.Exists(path))
            {
                int counter = 0;
                string line;

                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    System.Diagnostics.Debug.WriteLine(line);
                    counter++;
                }

                file.Close();
                System.Diagnostics.Debug.WriteLine("There were {0} lines.", counter);
            }
            return FileAsString;
        }
    }
}