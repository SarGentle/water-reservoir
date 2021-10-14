using System;

namespace WindowsFormsApplication1
{
    public class UnderWaterPlants : BaseClass
    {
        public override string GetClassCaption()
        {
            return "Планктоны и подводные растения";
        }

        private double _countOnAreaUnit;

        public double countOnAreaUnit
        {
            get
            {
                return _countOnAreaUnit;
            }
            set
            {
                _countOnAreaUnit = value;
            }
        }

        private double _growthSpeed;


        /// Скорость роста
        public double growthSpeed
        {
            get
            {
                return _growthSpeed;
            }
            set
            {
                _growthSpeed = value;
            }
        }

        private double _count;

        /// <summary>
        /// Общее количество планктонов и подводных растений
        /// </summary>
        public double count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        /// <summary>
        /// Моделирование роста планктонов и подводных растений
        /// </summary>
        /// <param name="availabalArea">Доступная площадь</param>
        public void grow(double availabalArea)
        {
            double totalCount = _count + _growthSpeed;
            double totalArea = totalCount / _countOnAreaUnit;
            if (totalArea > availabalArea) totalArea = availabalArea;
            _count = totalArea * _countOnAreaUnit;
        }
    }


    public class HerbivoreFishes
    {
        public virtual string GetClassCaption()
        {
            return "Растительноядные рыбы";
        }

        private double _foodNeed;

        /// <summary>
        /// Сколько одному животному нужно еды на единицу времени
        /// </summary>
        public double foodNeed
        {
            get
            {
                return _foodNeed;
            }
            set
            {
                _foodNeed = value;
            }
        }

        private double _growthSpeed;


        /// <summary>
        /// Скорость размножения, относительный прирост за единицу времени.
        /// </summary>
        public double growthSpeed
        {
            get
            {
                return _growthSpeed;
            }
            set
            {
                _growthSpeed = value;
            }
        }

        private int _count;

        /// <summary>
        /// Количество животных
        /// </summary>
        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        /// <summary>
        /// Жизненный цикл
        /// </summary>
        /// <param name="plant">Доступная пища</param>
        public void liveLoop(UnderWaterPlants plant)
        {
            double availabalFood = plant.count;
            double needFood = _count * _foodNeed;

            //проверим, хватает ли еды
            if (needFood > availabalFood)
            {
                //если еды не хватает,
                //то некоторые рыбы умирают
                int animalIsFull = Convert.ToInt32(availabalFood / _foodNeed); // скольки рыбам хватит еды
                _count = animalIsFull; //выживает только те, кто успел поесть

                //все растения и планктоны съедены
                plant.count = 0;
            }
            else
            {
                //еды хватило всем, рыбы размножаются
                _count = Convert.ToInt32(_count * (1 + _growthSpeed));

                //растительноядные рыбы съели растения, отразим этот факт, уменьшив кол-во растений
                plant.count = plant.count - needFood;
            }

        }
    }

    public class UnderWaterPredator
    {
        public virtual string GetClassCaption()
        {
            return "Хищные рыбы";
        }

        private int _foodNeed;

        /// <summary>
        /// Сколько одному хищнику нужно еды на единицу времени
        /// </summary>
        public int foodNeed
        {
            get
            {
                return _foodNeed;
            }
            set
            {
                _foodNeed = value;
            }
        }
        private double _growthSpeed;

        /// <summary>
        /// Скорость размножения, относительный прирост за единицу времени.
        /// </summary>
        public double growthSpeed
        {
            get
            {
                return _growthSpeed;
            }
            set
            {
                _growthSpeed = value;
            }
        }

        private int _count;

        /// <summary>
        /// Количество хищных рыб
        /// </summary>
        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        /// <summary>
        /// Жизненный цикл
        /// </summary>
        /// <param name="herbivore">Доступная пища</param>
        public void liveLoop(HerbivoreFishes herbivore)
        {
            int availabalFood = herbivore.count;
            int needFood = _count * _foodNeed;

            //проверим, хватает ли еды
            if (needFood > availabalFood)
            {
                //если еды не хватает,
                //то некоторые хищные рыбы умирают
                int animalIsFull = Convert.ToInt32(availabalFood / _foodNeed); // скольки рыбам хватит еды
                _count = animalIsFull; //выживает только те, кто успел поесть

                //все жертвы съедены
                herbivore.count = 0;
            }
            else
            {
                //еды хватило всем, хищные рыбы размножаются
                _count = Convert.ToInt32(_count * (1 + _growthSpeed));

                //хищные рыбы съели травоядных рыб, отразим этот факт, уменьшив кол-во растений
                herbivore.count = herbivore.count - needFood;
            }

        }
    }

    public class Area : BaseClass
    {
        private UnderWaterPlants _plant;

        public override string GetClassCaption()
        {
            return "Водоем";
        }

        /// <summary>
        /// Растения
        /// </summary>
        public UnderWaterPlants plant
        {
            get
            {
                return _plant;
            }
            set
            {
                _plant = value;
            }
        }

        private HerbivoreFishes _herbivore;

        /// <summary>
        /// Растительноядные рыбы
        /// </summary>
        public HerbivoreFishes herbivore
        {
            get
            {
                return _herbivore;
            }
            set
            {
                _herbivore = value;
            }
        }

        private UnderWaterPredator _predator;

        /// <summary>
        /// Хищные рыбы
        /// </summary>
        public UnderWaterPredator predator
        {
            get
            {
                return _predator;
            }
            set
            {
                _predator = value;
            }
        }

        private double _availabalArea;

        /// <summary>
        /// Доступная площадь
        /// </summary>
        public double availabalArea
        {
            get
            {
                return _availabalArea;
            }
            set
            {
                _availabalArea = value;
            }
        }

        /// <summary>
        /// Жизненный цикл
        /// </summary>
        public void liveLoop()
        {
            _plant.grow(_availabalArea);
            _herbivore.liveLoop(_plant);
            _predator.liveLoop(_herbivore);
        }
    }

}