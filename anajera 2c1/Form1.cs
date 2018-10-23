using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajera_2c1
{
    public partial class Form1 : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetMinButton_Click(object sender, EventArgs e)
        {
            byte1 = Byte.MinValue;  byte1TextBox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; sbyte1TextBox.Text = sbyte1.ToString();
            short1 = Int16.MinValue; short1TextBox.Text = short1.ToString();
            ushort1 = UInt16.MinValue; ushort1TextBox.Text = ushort1.ToString();
            int1 = Int32.MinValue; int1TextBox.Text = int1.ToString();
            uint1 = UInt32.MinValue; uint1TextBox.Text = uint1.ToString();
            long1 = Int64.MinValue; long1TextBox.Text = long1.ToString();
            ulong1 = UInt64.MinValue; ulong1TextBox.Text = ulong1.ToString();
            float1 = Single.MinValue; float1TextBox.Text = float1.ToString();
            double1 = Double.MinValue; double1TextBox.Text = double1.ToString();
            decimal1 = Decimal.MinValue; decimal1TextBox.Text = decimal1.ToString();
        }

        private void SetMaxButton_Click(object sender, EventArgs e)
        {
            byte2 = Byte.MaxValue; byte2TextBox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; sbyte2TextBox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; short2TextBox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; ushort2TextBox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; int2TextBox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; uint2TextBox.Text = uint2.ToString();
            long2 = Int64.MaxValue; long2TextBox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; ulong2TextBox.Text = ulong2.ToString();
            float2 = Single.MaxValue; float2TextBox.Text = float2.ToString();
            double2 = Double.MaxValue; double2TextBox.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; decimal2TextBox.Text = decimal2.ToString();
        }

        private void input1TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte1 = Convert.ToByte(input1TextBox.Text);
                byte1TextBox.Text = byte1.ToString();
            }
            catch (Exception) { byte1TextBox.Text = "error"; }
            try
            {
                sbyte1 = Convert.ToSByte(input1TextBox.Text);
                sbyte1TextBox.Text = sbyte1.ToString();
            }
            catch (Exception) { sbyte1TextBox.Text = "error"; }
            try
            {
                short1 = Convert.ToInt16(input1TextBox.Text);
                short1TextBox.Text = short1.ToString();
            }
            catch (Exception) { short1TextBox.Text = "error"; }
            try
            {
                ushort1 = Convert.ToUInt16(input1TextBox.Text);
                ushort1TextBox.Text = ushort1.ToString();
            }
            catch (Exception) { ushort1TextBox.Text = "error"; }
            try
            {
                int1 = Convert.ToInt32(input1TextBox.Text);
                int1TextBox.Text = int1.ToString();
            }
            catch (Exception) { int1TextBox.Text = "error"; }
            try
            {
                uint1 = Convert.ToUInt32(input1TextBox.Text);
                uint1TextBox.Text = uint1.ToString();
            }
            catch (Exception) { uint1TextBox.Text = "error"; }
            try
            {
                long1 = Convert.ToInt64(input1TextBox.Text);
                long1TextBox.Text = long1.ToString();
            }
            catch (Exception) { long1TextBox.Text = "error"; }
            try
            {
                ulong1 = Convert.ToUInt64(input1TextBox.Text);
                ulong1TextBox.Text = ulong1.ToString();
            }
            catch (Exception) { ulong1TextBox.Text = "error"; }
            try
            {
                float1 = Convert.ToSingle(input1TextBox.Text);
                float1TextBox.Text = float1.ToString();
            }
            catch (Exception) { float1TextBox.Text = "error"; }
            try
            {
                double1 = Convert.ToDouble(input1TextBox.Text);
                double1TextBox.Text = double1.ToString();
            }
            catch (Exception) { double1TextBox.Text = "error"; }
            try
            {
                decimal1 = Convert.ToDecimal(input1TextBox.Text);
                decimal1TextBox.Text = decimal1.ToString();
            }
            catch (Exception) { decimal1TextBox.Text = "error"; }
        }
        private void Input2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2TextBox.Text);
                byte2TextBox.Text = byte2.ToString();
            }
            catch (Exception) { byte2TextBox.Text = "error"; }
            try
            {
                sbyte2 = Convert.ToSByte(input2TextBox.Text);
                sbyte2TextBox.Text = sbyte2.ToString();
            }
            catch (Exception) { sbyte2TextBox.Text = "error"; }
            try
            {
                short2 = Convert.ToInt16(input2TextBox.Text);
                short2TextBox.Text = short2.ToString();
            }
            catch (Exception) { short2TextBox.Text = "error"; }
            try
            {
                ushort2 = Convert.ToUInt16(input2TextBox.Text);
                ushort2TextBox.Text = ushort2.ToString();
            }
            catch (Exception) { ushort2TextBox.Text = "error"; }
            try
            {
                int2 = Convert.ToInt32(input2TextBox.Text);
                int2TextBox.Text = int2.ToString();
            }
            catch (Exception) { int2TextBox.Text = "error"; }
            try
            {
                uint2 = Convert.ToUInt32(input2TextBox.Text);
                uint2TextBox.Text = uint2.ToString();
            }
            catch (Exception) { uint2TextBox.Text = "error"; }
            try
            {
                long2 = Convert.ToInt64(input2TextBox.Text);
                long2TextBox.Text = long2.ToString();
            }
            catch (Exception) { long2TextBox.Text = "error"; }
            try
            {
                ulong2 = Convert.ToUInt64(input2TextBox.Text);
                ulong2TextBox.Text = ulong2.ToString();
            }
            catch (Exception) { ulong2TextBox.Text = "error"; }
            try
            {
                float2 = Convert.ToSingle(input2TextBox.Text);
                float2TextBox.Text = float2.ToString();
            }
            catch (Exception) { float2TextBox.Text = "error"; }
            try
            {
                double2 = Convert.ToDouble(input2TextBox.Text);
                double2TextBox.Text = double2.ToString();
            }
            catch (Exception) { double2TextBox.Text = "error"; }
            try
            {
                decimal2 = Convert.ToDecimal(input2TextBox.Text);
                decimal2TextBox.Text = decimal2.ToString();
            }
            catch (Exception) { decimal2TextBox.Text = "error"; }
        }
    }
}
