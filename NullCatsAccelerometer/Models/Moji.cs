using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NullCatsAccelerometer.Models
{

    public class Moji
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Durationlimit DurationLimit { get; set; }
        public int NoOfVehicleStates { get; set; }
        public RPM RPM { get; set; }
        public Speed Speed { get; set; }
        public Fuel Fuel { get; set; }
        public Fuelefficiency FuelEfficiency { get; set; }
        public Battery Battery { get; set; }
        public Points Points { get; set; }
        public bool CircularTrip { get; set; }
        public Vehiclestate[] VehicleStates { get; set; }
    }

    public class Durationlimit
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class RPM
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Speed
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Fuel
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Fuelefficiency
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Battery
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Points
    {
        public float[] Start { get; set; }
        public float[] End { get; set; }
        public object[] WayPoint { get; set; }
    }

    public class Vehiclestate
    {
        public Vehicle Vehicle { get; set; }
        public Telematicdevice TelematicDevice { get; set; }
        public Includeddata IncludedData { get; set; }
    }

    public class Vehicle
    {
        public string VIN { get; set; }
        public bool MilStatus { get; set; }
        public Acceleration Acceleration { get; set; }
        public Deceleration Deceleration { get; set; }
        public RPM1 RPM { get; set; }
        public Ignitionstate IgnitionState { get; set; }
        public Speed1 Speed { get; set; }
        public Fuelefficiency1 FuelEfficiency { get; set; }
        public Fuellevel FuelLevel { get; set; }
        public Battery1 Battery { get; set; }
        public Location Location { get; set; }
        public Accelerometer Accelerometer { get; set; }
        public Heading Heading { get; set; }
        public Virtualodometer VirtualOdometer { get; set; }
        public Diagnosticcode[] DiagnosticCodes { get; set; }
        public Towstate TowState { get; set; }
        public Accidentstate AccidentState { get; set; }
        public Idlestate IdleState { get; set; }
        public Harsheventstate HarshEventState { get; set; }
        public Parkedstate ParkedState { get; set; }
    }

    public class Acceleration
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Deceleration
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class RPM1
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Ignitionstate
    {
        public bool Value { get; set; }
    }

    public class Speed1
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Fuelefficiency1
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Fuellevel
    {
        public string Unit { get; set; }
        public float Value { get; set; }
    }

    public class Battery1
    {
        public bool Connected { get; set; }
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Location
    {
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string Status { get; set; }
        public int Dilution { get; set; }
        public bool IsValid { get; set; }
        public int Altitude { get; set; }
    }

    public class Accelerometer
    {
        public X X { get; set; }
        public Y Y { get; set; }
        public Z Z { get; set; }
    }

    public class X
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Y
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Z
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Heading
    {
        public float Value { get; set; }
    }

    public class Virtualodometer
    {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Towstate
    {
        public string Value { get; set; }
        public string Type { get; set; }
    }

    public class Accidentstate
    {
        public bool Value { get; set; }
    }

    public class Idlestate
    {
        public bool Value { get; set; }
    }

    public class Harsheventstate
    {
        public bool Value { get; set; }
        public string EventType { get; set; }
        public string TurnType { get; set; }
    }

    public class Parkedstate
    {
        public bool Value { get; set; }
    }

    public class Diagnosticcode
    {
        public string Code { get; set; }
    }

    public class Telematicdevice
    {
        public string IMEI { get; set; }
        public Awakestate AwakeState { get; set; }
        public Gpsradio GPSRadio { get; set; }
        public Connectedstate ConnectedState { get; set; }
        public Obdfirmware OBDFirmware { get; set; }
    }

    public class Awakestate
    {
        public string AwakeReason { get; set; }
        public bool Value { get; set; }
    }

    public class Gpsradio
    {
        public Location1 Location { get; set; }
    }

    public class Location1
    {
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string Status { get; set; }
        public int Dilution { get; set; }
        public bool IsValid { get; set; }
        public int Altitude { get; set; }
    }

    public class Connectedstate
    {
        public bool Value { get; set; }
    }

    public class Obdfirmware
    {
        public string FirmwareType { get; set; }
        public string Version { get; set; }
    }

    public class Includeddata
    {
        public bool Diagnostics { get; set; }
    }

}