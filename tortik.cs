namespace proba
{
    public class tortik
    {
        private string _Shape;
        private int ShapePrice;
        public string Shape
        {
            get { return _Shape; }
            set
            {
                if (value == _Shape)
                    return;
                _Shape = value;
                if (ShapePrice != 0)
                    TotalPrice -= ShapePrice;
                switch (value)
                {
                    case "Круг":
                        ShapePrice = 500;
                        break;
                    case "Квадрат":
                        ShapePrice = 500;
                        break;
                    case "Ромб":
                        ShapePrice = 500;
                        break;
                    case "Сердечко":
                        ShapePrice = 700;
                        break;
                }
                TotalPrice += ShapePrice;
            }
        }

        private string _Size;
        private int SizePrice = 0;
        public string Size
        {
            get { return _Size; }
            set
            {
                if (value == _Size)
                    return;
                _Size = value;
                if (SizePrice != 0)
                    TotalPrice -= SizePrice;
                switch (value)
                {
                    case "Маленький":
                        SizePrice = 1000;
                        break;
                    case "Обычный":
                        SizePrice = 1200;
                        break;
                    case "Большой":
                        SizePrice = 2000;
                        break;
                }
                TotalPrice += SizePrice;
            }
        }

        private int? _korj_amount=null;
        private int korj_amountPrice = 0;
        public int? korj_amount
        {
            get { return _korj_amount; }
            set
            {
                if (value == _korj_amount||value<0||value>4)
                    return;
                _korj_amount = value;
                if (SizePrice != 0)
                    TotalPrice -= korj_amountPrice;
                switch (value)
                {
                    case 1:
                        korj_amountPrice = 200;
                        break;
                    case 2:
                        korj_amountPrice = 400;
                        break;
                    case 3:
                        korj_amountPrice = 600;
                        break;
                    case 4:
                        korj_amountPrice = 800;
                        break;

                }
                TotalPrice += korj_amountPrice;
            }
        }
        private string _korj_Taste;
        private int korj_TastePrice = 0;
        public string korj_Taste
        {
            get { return _korj_Taste; }
            set
            {
                if(_korj_Taste == value)
                    return;
                if (_korj_amount == null)
                {
                    Console.Clear();
                    Console.WriteLine("Не указано количество коржей");
                    Console.ReadLine();
                    return;
                }
                _korj_Taste = value;
                if (SizePrice != 0)
                    TotalPrice -= korj_TastePrice;
                switch (value)
                {
                    case "Ванильный":
                        korj_TastePrice = 200;
                        break;
                    case "Шоколадный":
                        korj_TastePrice = 100;
                        break;
                    case "Карамельный":
                        korj_TastePrice = 150;
                        break;
                    case "Ягодный":
                        korj_TastePrice = 200;
                        break;
                    case "Кокосовый":
                        korj_TastePrice = 250;
                        break;
                }
                TotalPrice += korj_amountPrice;
            }
        }
        private string _Glazure;
        private int GlazurePrice = 0;

        public int TotalPrice;
        public string Glazure
        {
            get { return _Glazure; }
            set
            {
                if (value == _Glazure)
                    return;
                _Glazure = value;
                if (GlazurePrice != 0)
                    TotalPrice -= GlazurePrice;
                switch (value)
                {
                    case "Шоколад":
                        GlazurePrice = 100;
                        break;
                    case "Крем":
                        GlazurePrice = 100;
                        break;
                    case "Бизе":
                        GlazurePrice = 150;
                        break;
                    case "Драже":
                        GlazurePrice = 150;
                        break;
                    case "Ягоды":
                        GlazurePrice = 200;
                        break;
                }
                TotalPrice += GlazurePrice;
            }
        }
        private string _Decoration;
        private int DecorationPrice = 0;
        public string Decoration
        {
            get { return _Decoration; }
            set
            {
                if (value == _Decoration)
                    return;
                _Decoration = value;
                if (DecorationPrice != 0)
                    TotalPrice -= DecorationPrice;
                switch (value)
                {
                    case "Шоколадная":
                        DecorationPrice = 150;
                        break;
                    case "Ягодная":
                        DecorationPrice = 150;
                        break;
                    case "Кремовая":
                        DecorationPrice = 150;
                        break;

                }
                TotalPrice += DecorationPrice;
            }

        }
        public string CreateMessage()
        {
            return $"\n\n Ваш заказ: \nФорма: {Shape??"Не указано"} \nРазмер: {Size ?? "Не указано"} \nКол-во коржей: {korj_amount??0} \nВкус коржей: {korj_Taste ?? "Не указано"} \nГлазурь: {Glazure ?? "Не указано"} \nНачинка: {Decoration ?? "Не указано"}";
        }
    }
}
