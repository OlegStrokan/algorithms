namespace data_structures;

    class IndexatorsPerson
    {
        public string Name { get;}
        public IndexatorsPerson(string name) => Name=name;
    }
    class IndexatorsCompany
    {
        IndexatorsPerson[] personal;
        public IndexatorsCompany(IndexatorsPerson[] people) => personal = people;
        // индексатор
        public IndexatorsPerson this[int index]
        {
            get => personal[index];
            set => personal[index] = value;
        }
    }