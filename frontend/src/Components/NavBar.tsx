import { useState } from "react";
import bgWaves from "../assets/Images/bg-waves.png"
import logo from "../assets/Images/logo.png"
function NavBar(){

const [mobileNavOpen, setMobileNavOpen] = useState(false);

return ( 
    <section className="relative bg-teal-900"> <img className="absolute top-0 left-0 w-full h-full" src={bgWaves} alt="" />
        <nav className="py-6">
                <div className="container mx-auto px-4">
                <div className="relative flex items-center justify-between"><a className="inline-block" href="#!"><img className="h-8" src={logo} alt=""/></a>
                    <ul className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 hidden md:flex">
                    <li className="mr-8"><a className="inline-block text-white hover:text-lime-500 font-medium" href="about.html">Events</a></li>
                    <li className="mr-8"><a className="inline-block text-white hover:text-lime-500 font-medium" href="pricing.html">Announcement</a></li>
                    <li className="mr-8"><a className="inline-block text-white hover:text-lime-500 font-medium" href="contact.html">Members</a></li>
                    <li><a className="inline-block text-white hover:text-lime-500 font-medium" href="blog.html">Register</a></li>
                    </ul>
                    <div className="flex items-center justify-end">
                    <div className="hidden md:block"><a className="inline-flex group py-2.5 px-4 items-center justify-center text-sm font-medium text-white hover:text-teal-900 border border-white hover:bg-white rounded-full transition duration-200" href="contact.html"><span className="mr-2">Get in touch</span> <span className="transform group-hover:translate-x-0.5 transition-transform duration-200">
                        </span></a></div>
                    <button className="md:hidden text-white hover:text-lime-500" onClick={() => setMobileNavOpen(!mobileNavOpen)}>
                         Menu
                    </button>
                    </div>
                </div>
            </div>
        </nav> 

       <div className="relative pt-18 pb-24 sm:pb-32 lg:pt-36 lg:pb-62">
            <div className="container mx-auto px-4 relative">
              <div className="max-w-lg xl:max-w-xl mx-auto text-center">
                <h1 className="font-heading text-5xl xs:text-7xl xl:text-8xl tracking-tight text-white mb-8">Welcome To Our Barangay System</h1>
                <p className="max-w-md xl:max-w-none text-lg text-white opacity-80 mb-10">This Website serve as the primary planning and implementing body for community programs and services. It ensures local governance, peace and order, and the welfare of residents through leadership, public services, and community participation.</p><a className="inline-flex py-4 px-6 items-center justify-center text-lg font-medium text-teal-900 border border-lime-500 hover:border-white bg-lime-500 hover:bg-white rounded-full transition duration-200" href="#!">See more</a>
              </div>
            </div>
        </div>

        </section>
    );

}

export default NavBar;