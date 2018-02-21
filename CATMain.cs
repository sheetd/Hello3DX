using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using INFITF; //CATIA InfInterfaces Object Library

namespace Hello3DX
{
    class CATMain
    {
        public static INFITF.Application catia;
        private INFITF.Document activeDoc;

        // statically defines one active CATIA session
        public static bool engageActiveCatiaSession()
        {
            if (Program.ENGAGE_CATIA_MODE)
            {
                try
                {
                    catia = (INFITF.Application)Marshal.GetActiveObject("catia.Application");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ooops! Exception: " + ex.ToString());
                    MessageBox.Show("Could not find an active session! Please launch 3DEXPERIENCE.",
                                    "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        // sets CATIA active document
        public bool setActiveDocument()
        {
            if (Program.ENGAGE_CATIA_MODE)
            {
                try
                {
                    activeDoc = catia.ActiveDocument;
                }
                catch (COMException ex)
                {
                    Console.WriteLine("Could not obtain the CATIA active document!" + " Exception: " + ex.ToString());
                    MessageBox.Show("Could not obtain a CATIA active document. Please open one.",
                                    "Oops! No open document!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            return false;
        }

        // Testing Area
        public void test()
        {
            Console.WriteLine("--> start test");

            // Adds a geo set to the active part & zooms all
            INFITF.Editor myEditor;
            myEditor = catia.ActiveEditor;

            MECMOD.Part myPart;
            myPart = (MECMOD.Part)myEditor.ActiveObject;

            MECMOD.HybridBodies hybridBodies1;
            hybridBodies1 = myPart.HybridBodies;

            MECMOD.HybridBody hybridBody1;
            hybridBody1 = hybridBodies1.Add();

            myPart.Update();

            catia.StartCommand("Fit all in");
        }
    }
}