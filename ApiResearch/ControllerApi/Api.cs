using Backend;

namespace ControllerApi;

public class Api{
    
    private Repository _repository { get; }
    
    public Api(Repository repository){
        _repository = repository;
    }
}