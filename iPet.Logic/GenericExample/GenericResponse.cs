using System;
namespace iPet.Logic.GenericExample
{
    public static class GenericResponse
    {

        public static Employee changeEmployeeName<T>(String _name, Employee _employee){

            //Use t for parse JSON or instantiante class

            return new Employee(_name, _employee.ID);
        }

        public static T InstantiateType<T>(string firstName, int _id) where T : Employee, new()
		{
			T obj = new T();
            obj.Name = firstName;
            obj.ID = _id;
			return obj;
		}
    }
}
