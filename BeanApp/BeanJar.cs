using System;
using System.Collections.Generic;
using System.Text;

namespace BeanieApplication
{
    public class BeanJar
    {
        public const int MAX_CAPACITY = 2000;
        public const int MIN_CAPACITY = 1;

        readonly Dictionary<BeanFlavor, List<Bean>> _beans;
        int _totalBeanCount;

        public BeanJar()
        {
            _beans = new Dictionary<BeanFlavor, List<Bean>>();
            _totalBeanCount = 0;
        }

        #region properties

        public int TotalBeanCount => _totalBeanCount;

        public int Capacity { get; set; }

        #endregion

        public void AddBean(Bean bean)
        {
            if (_totalBeanCount >= Capacity)
                return;

            if (_beans.ContainsKey(bean.Flavor))
                _beans[bean.Flavor].Add(bean);
            else
            {
                var beans = new List<Bean>();
                beans.Add(bean);

                _beans.Add(bean.Flavor, beans);
            }

            _totalBeanCount += 1;
        }

        public string GetStatistics()
        {
            var statisticsBuilder = new StringBuilder($"Bean Container - Capacity {Capacity}{Environment.NewLine}");
            foreach(var flavor in _beans.Keys)
            {
                var beans = _beans[flavor];
                statisticsBuilder.AppendFormat("> {0} ({3}) - {1} Beans - {2}%{4}", 
                    flavor, 
                    beans.Count, 
                    (beans.Count * 100) / TotalBeanCount, 
                    beans[0].Color,
                    Environment.NewLine);
            }
            statisticsBuilder.AppendLine();

            return statisticsBuilder.ToString();
        }

        public override string ToString()
        {
            return $"Jar Capacity: {Capacity}";
        }
    }
}
