namespace FactoryMethod.RealExample
{
    /**factory-method example**/
    public abstract class Application{  
        
        public void Create(){
            View contentView = CreateContentView();
            Menu menu = contentView.ObtainMenu();
            GenerateMenuItems(menu);
        }
        public abstract View CreateContentView(); //factory-method
        
        public void GenerateMenuItems(Menu menu){
            // some code
        }
    }
}
