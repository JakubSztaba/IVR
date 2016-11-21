using IVR.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace IVR.prompts
{
    class PromptPlayer : IPlayer
    {
        private List<Prompt> prompt_list = new List<Prompt>();
        private SoundPlayer player;
        private Thread thread;

        public PromptPlayer(List<Prompt> prompt_list_)
        {
            this.prompt_list = prompt_list_;
            player = new SoundPlayer();
            thread = new Thread(Play); 
            
        }

        public PromptPlayer(Prompt prompt_)
        {
            this.prompt_list.Add(prompt_);
            player = new SoundPlayer();
            thread = new Thread(Play);
        }

        public PromptPlayer()
        {
            player = new SoundPlayer();
            thread = new Thread(Play);
        }

        public void SetPrompt(Prompt prompt_)
        {
            this.prompt_list.Add(prompt_);
        }

        public void SetPrompts(List<Prompt> prompts_)
        {
            this.prompt_list = prompts_;
        }

        public void Play()
        {          
            foreach ( Prompt p in prompt_list)
            {
                player.SoundLocation = p.path;
                player.Load();
                player.PlaySync();
                
            }           
        }

        public void StaticPlay()
        {
            foreach (Prompt p in prompt_list)
            {
                player.SoundLocation = p.path;
                player.Load();
                player.Play();

            }
        }



        public void ThreadPlay()
        {    
            thread.Start();
        }

        public void ThreadStop()
        {
            thread.Abort();
        }
        public void Stop()
        {

            this.player.Stop();
        }
    }
}