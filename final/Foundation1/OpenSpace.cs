public class OpenSpace
{
    //member variables - attributes
    private string _name;
    public string _planet { get; set; }   //type: prop 


    //member functions - methods
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    } 
}
