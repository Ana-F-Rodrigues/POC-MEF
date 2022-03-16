using BSIL.POC.MEFDatabase;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Composition;


namespace BSIL.POC.ConsoleApp
{
    public  class Container
    {
        [System.ComponentModel.Composition.Import(typeof(IDatabase))]
        public IDatabase Database { get; set; }

        public Container()
        {
            DirectoryCatalog catalog = new DirectoryCatalog("Plugins");
            CompositionContainer container = new CompositionContainer(catalog);
            CompositionBatch batch = new CompositionBatch();
            batch.AddPart(this);
            container.Compose(batch);
        }
    }
}
    

