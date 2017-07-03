using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Bread_Checker
{
    public partial class Dog_Breed_Form : Form
    {
        public Dog_Breed_Form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List of Carriers which provide some form of animal coverage
            List<Label> IncludeAnimalCarriers = new List<Label> 
                { 
                  this.labelAmInt, this.labelAmTrad, this.labelArkRoyal, this.labelASIPref, this.labelBankers,
                  this.labelCapPPref, this.labelCapPStan, this.labelCitizens, this.labelCypress, this.labelEdison,
                  this.labelElemDiam, this.labelElemSel, this.labelFlFam, this.labelFlPenElite, this.labelFlPenPref,
                  this.labelFrontlineGaurd, this.labelGeoVera, this.labelGulfstream, this.labelGulfstream, this.labelHeritage,
                  this.labelOlympus, this.labelPrepared,  this.labelSafepoint, this.labelSafeway, this.labelSecFirst,
                  this.labelSoFidStan, this.labelSoOakGold, this.labelSoOakStan, this.labelStJohns, this.labelTowHillOmega,
                  this.labelTowHillPref, this.labelTowHillPrime, this.labelTowHillSelect, this.labelTowHillSig,
                  this.labelUnitedPC
                };

            //List of Carriers which provide no animal coverage at all
            List<Label> ExcludeAnimalCarriers = new List<Label> 
                {
                  this.labelFedNat, this.labelFrontline, this.labelSawMutal, this.labelSoFidPC, this.labelSoFidPref,
                  this.labelUniversalPC
                };


            //Conditional Statement which will turn carriers boxes 1 of 4 colors based on selected breed
            //Green  (PaleGreen)    = Eligible for Animal Coverage or not specified
            //Yellow (Khaki)        = Excluded from animal coverage
            //Orange (Orange)       = All animal coverage excluded
            //Red    (LightCoral)   = Ineligible/Unbindable Risk
            switch(comboBox1.Text)
            {
                case ("Staffordshire Bull Terrier"):
                     foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelAmTrad.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSawMutal.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    labelUniversalPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGeoVera.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("American Staffordshire Terrier"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelAmTrad.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSawMutal.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    labelUniversalPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGeoVera.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Pit Bull"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelAmTrad.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlFam.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelFrontlineGaurd.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSawMutal.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    labelUniversalPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGeoVera.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelSoOakStan.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Akita"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlFam.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelFrontlineGaurd.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    labelUniversalPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Chow Chow"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlFam.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelFrontlineGaurd.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGeoVera.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelSoOakStan.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Doberman Pinscher"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlFam.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelFrontlineGaurd.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGeoVera.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelSoOakStan.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("German Shepherd Dog"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelFrontlineGaurd.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Rottweiler"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelFlFam.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelFrontlineGaurd.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSawMutal.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGeoVera.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelSoOakStan.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Great Dane"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("American Bulldog"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelHeritage.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Presa Canario"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmInt.BackColor = Color.LightCoral;
                    labelBankers.BackColor = Color.LightCoral;
                    labelCypress.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelFrontlineGaurd.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelHeritage.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Caucasian Mountain Dog"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelHeritage.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Beauceron"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelArkRoyal.BackColor = Color.LightCoral;
                    labelASIPref.BackColor = Color.LightCoral;
                    labelSafeway.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelHeritage.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Rhodesian Ridgeback"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelAmTrad.BackColor = Color.LightCoral;
                    break;
                case ("Siberian Husky"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelBankers.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    break;
                case ("Alaskan Malamute"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelBankers.BackColor = Color.LightCoral;
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    break;
                case ("Cane Corso"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelBankers.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    break;
                case ("Catahoula Leopard"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelCypress.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelElemDiam.BackColor = Color.Khaki;
                    labelElemSel.BackColor = Color.Khaki;
                    labelGulfstream.BackColor = Color.Khaki;
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    break;
                case ("Bullmastiff"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelFlPenElite.BackColor = Color.LightCoral;
                    labelFlPenPref.BackColor = Color.LightCoral;
                    labelSoOakGold.BackColor = Color.LightCoral;
                    labelUnitedPC.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelEdison.BackColor = Color.Khaki;
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("Keeshond"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Ineligible/Unbindable
                    labelSafeway.BackColor = Color.LightCoral;
                    labelTowHillOmega.BackColor = Color.LightCoral;
                    labelTowHillPref.BackColor = Color.LightCoral;
                    labelTowHillPrime.BackColor = Color.LightCoral;
                    labelTowHillSelect.BackColor = Color.LightCoral;
                    labelTowHillSig.BackColor = Color.LightCoral;
                    //Excluded from Animal Coverage
                    labelHeritage.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    labelSafepoint.BackColor = Color.Khaki;
                    labelSecFirst.BackColor = Color.Khaki;
                    break;
                case ("Fox Terrier"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Excluded from Animal Coverage
                    labelOlympus.BackColor = Color.Khaki;
                    labelPrepared.BackColor = Color.Khaki;
                    break;
                case ("Belgian Malinois"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Excluded from Animal Coverage
                    labelStJohns.BackColor = Color.Khaki;
                    break;
                case ("American Eskimo Dog"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Excluded from Animal Coverage
                    labelUnitedPC.BackColor = Color.LightCoral;
                    break;
                case ("Giant Schnauzer"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Excluded from Animal Coverage
                    labelUnitedPC.BackColor = Color.LightCoral;
                    break;
                case ("Korean Jindo"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Excluded from Animal Coverage
                    labelUnitedPC.BackColor = Color.LightCoral;
                    break;
                case ("Thai Ridgeback"):
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    //Excluded from Animal Coverage
                    labelUnitedPC.BackColor = Color.LightCoral;
                    break;
                default:
                    foreach (Label carrier in IncludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.PaleGreen;
                    }
                    foreach (Label carrier in ExcludeAnimalCarriers)
                    {
                        carrier.BackColor = Color.Orange;
                    }
                    break;
            }
        }
    }
}
