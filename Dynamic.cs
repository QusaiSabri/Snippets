public class Dynamic: DynamicObject
    {
        Dictionary<string, object> _dictionary = new Dictionary<string, object>();
       
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return _dictionary.TryGetValue(binder.Name, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            return true;
        }

        public void AddProperty(string name, object value)
        {
            _dictionary[name] = value;
        }
    }
