using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        ////private int id;
        //public int Id { get; }
        //private static int nextId = 1;
        ////private string value;
        //public string Value { get; set; }

        //// TODO: Change the fields to auto-implemented properties.

        //public CoreCompetency()
        //{
        //    //id = nextId;
        //    Id = nextId;
        //    nextId++;
        //}

        //public CoreCompetency(string v) : this()
        //{
        //    //value = v;
        //    Value = v;
        //}

        public CoreCompetency() : base () { }
        public CoreCompetency(string value) : base(value) { }

        //public override bool Equals(object obj)
        //{
        //    return obj is CoreCompetency competency &&
        //           //id == competency.id;
        //           Id == competency.Id;
        //}

        //public override int GetHashCode()
        //{
        //    //return HashCode.Combine(id);
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    //return value;
        //    return Value;
        //}
    }
}
