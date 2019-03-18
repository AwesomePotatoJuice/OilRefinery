using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilRefinery
{
    class RefiningState
    {
        private int days;
        private int maxTemp;
        private double organicOxidation;
        private double oilOxidation;
        private double humus;
        private double volume;

        public void setDays(int days)
        {
            this.days = days;
        }
        public int getDays()
        {
            return days;
        }
        public void setMaxTemp(int maxTemp)
        {
            this.maxTemp = maxTemp;
        }
        public int getMaxTemp()
        {
            return maxTemp;
        }
        public void setOrganicOxidation(double organicOxidation)
        {
            this.organicOxidation = organicOxidation;
        }
        public double getOrganicOxidation()
        {
            return organicOxidation;
        }
        public void setOilOxidation(double oilOxidation)
        {
            this.oilOxidation = oilOxidation;
        }
        public double getOilOxidation()
        {
            return oilOxidation;
        }
        public void setHumus(double humus)
        {
            this.humus = humus;
        }
        public double getHumus()
        {
            return humus;
        }
        public void setVolume(double volume)
        {
            this.volume = volume;
        }
        public double getVolume()
        {
            return volume;
        }
    }
}
