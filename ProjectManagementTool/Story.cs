using System;

namespace ProjectManagementTool
{
    class Priority
    {
        public static readonly int High = 1;
        public static readonly int Medium = 2;
        public static readonly int Low = 3;
    }
    class Story
    {
        private String _id;
        private String _title;
        private String _description;
        private readonly DateTime _createDate;
        private String _status;
        private int _priority;

        public Story()
        {
        }

        public Story(String title) : this(title, "")
        {
        }

        public Story(String title, String description)
        {
            _id = Guid.NewGuid().ToString();
            _title = title;
            _description = description;
            _createDate = DateTime.Now;
            _status = "BACKLOG";
        }

        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime CreateDate
        {
            get { return _createDate; }
        }

        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            if (Id.Equals(((Story) obj).Id))
                return true;
            return false;
        }
    }
}
