using UnityEngine;

public class DroneInfo 
{
    // Setup battery
    public float battery_voltage = 3 * 4.2f; // Volts
    public float battery_resistance = 0.00317f; // Ohms
    public float battery_capacity = 3.5f; // Ah
    public float battery_dropped_voltage; // Volts
    public float battery_current; // Volts
    public float copter_mass = 1.282f; // Kg
    public float copter_inertia; 
    public float density = 1.225f; // kg/m^3
    public Vector3 copter_cd = new Vector3(0.5f,0.5f,0.5f);
    public Vector3 copter_cd_ref_area = Vector3.one * Mathf.PI * 0.0081f;  

    public void Init()
    {
        copter_inertia = 0.2f * copter_mass * Mathf.Pow(0.45f * 0.2f, 2);
    }

    public void Reset()
    {
        battery_dropped_voltage = 0;
        battery_current = 0;
    }

}
