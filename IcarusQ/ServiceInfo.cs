using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcarusQ
{
    internal class ServiceInfo
    {
        // Store info here
        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private float  serviceCost;
        private int    serviceTag;

        // Constructors
        public ServiceInfo(string newName, string newModel, string newProblem, float newCost, int newTag)
        {
            clientName = newName;
            droneModel = newModel;
            serviceProblem = newProblem;
            serviceCost = newCost;
            serviceTag = newTag;
        }

        // Getters
        public string getClientName() { return clientName; }
        public string getDroneModel() { return droneModel; }
        public string getServiceProblem() { return serviceProblem; }
        public float getServiceCost() { return serviceCost; }
        public int getServiceTag() { return serviceTag; }
         
        // Setters
        public void setClientName(string newName) { clientName = newName; }
        public void setDroneModel(string newModel) { droneModel = newModel; }
        public void setServiceProblem(string newProblem) { serviceProblem = newProblem; }
        public void setServiceCost(int newCost) { serviceCost = newCost; }
        public void setServiceTag(int newTag) { serviceTag = newTag; }

    }
}
