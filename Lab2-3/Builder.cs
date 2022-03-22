using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{

    public interface IPageBuilder
    {
        void BuildComputer(Computer computer);
        void BuildProc(Proc proc);
        void BuildVideo(Video video);
    }
    public class PageDirector
    {
        private readonly IPageBuilder _builder;
        private Computer BuildComputer(int pageId)
        {
            Computer Bcomputer = new Computer();
            return Bcomputer;
        }
        private Proc BuildProc()
        {
            Proc BPorc = new Proc();
            return BPorc;
        }

        private Video BuildVideo()
        {
            Video BVideo = new Video();
            return BVideo;
        }
        public PageDirector(IPageBuilder builder)
        {
            this._builder = builder;
        }
        public void BuildPage(int pageId)
        {
            this._builder.BuildComputer(this.BuildComputer(pageId));


        }
    }
    public class PageBuilder : Form1, IPageBuilder
    {
        private readonly Computer _computer = new Computer();
        public void BuildComputer(Computer Bcomputer) { this._computer.BuildComputer(); }
        public void BuildProc(Proc Bproc) { this._computer.BuildProc(); }
        public void BuildVideo(Video Bvideo) { this._computer.BuildVideo(); }
            
        public Computer GetResult() { return this._computer; }

        public Computer PostPage(int pageId)
        {
            PageBuilder pageBuilder = new PageBuilder();
            PageDirector pageDirector = new PageDirector(pageBuilder);
            pageDirector.BuildPage(pageId);
            Computer computer = new Computer();
            computer = computer.BuildComputer();
            return computer;


            
            
        }
    }
      
    
    
}
