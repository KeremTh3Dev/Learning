using System;
using System.Text;


namespace Learning.Homeworks.IATAFlightDispatchSystem
{
    public class FlightDispatcher
    {
        const double KgToLbsRate = 2.20462;
        string[] awbNumbers = new string[4];
        double[] cargoWeights = new double[4];

        public int GetTotalWeightLbs()
        {
            return (int)(KgToLbsRate * (cargoWeights[0] + cargoWeights[1] + cargoWeights[2] + cargoWeights[3]));
        }
        public void LoadCargo(int index, string awb, double weightKg)
        {
            awbNumbers[index] = awb;
            cargoWeights[index] = weightKg;
        }
        public bool ApproveFlightPlan(bool isFuelSufficient, bool HasSlotTime, bool containsHazmat, bool pilotHazmatCertified)
        {
            return isFuelSufficient && HasSlotTime && (!containsHazmat || pilotHazmatCertified);
        }
        public void printManifest(Aircraft aircraft)
        {
            var listed_AwbNumbers = string.Join(" | ", awbNumbers);
            int totalLbs = GetTotalWeightLbs();
            bool isApproved = ApproveFlightPlan(true, true, false, true);

            var manifest = string.Format(@"=========================================
FLIGHT DISPATCH MANIFEST
=========================================
AIRCRAFT: {0} ({1})
TOTAL CARGO WEIGHT: {2} LBS
TRACKING NUMBERS:
> {3}

CLEARANCE STATUS: {4}
=========================================", aircraft.TailNumber, aircraft.Model, totalLbs, listed_AwbNumbers, isApproved ? "APPROVED" : "REJECTED");
            Console.WriteLine(manifest);
        }
    }
}
