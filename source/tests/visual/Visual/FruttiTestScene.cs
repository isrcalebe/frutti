namespace frutti.Game.Tests.Visual;

public abstract partial class FruttiTestScene : TestScene
{
    protected override ITestSceneTestRunner CreateRunner()
        => new FruttiTestRunner();

    private partial class FruttiTestRunner : FruttiGameBase, ITestSceneTestRunner
    {
        private TestSceneTestRunner.TestRunner? runner;

        protected override void LoadAsyncComplete()
        {
            Add(runner = new TestSceneTestRunner.TestRunner());

            base.LoadAsyncComplete();
        }

        public void RunTestBlocking(TestScene scene)
            => runner?.RunTestBlocking(scene);
    }
}
