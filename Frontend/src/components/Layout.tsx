import { Link, Outlet } from "react-router-dom";
import { useState, useEffect } from "react";
import "../styles/Layout.css"
import logo from "../assets/Media/Philip_milanov_Logo_Placeholder.png";





export default function LayOut() {

    // setIsCareerOpen == Function to change value through isCareerOpen (boolean)
    const [isCareerOpen, setIsCareerOpen] = useState(false);

    // Runs once, after the component first renders (because of empty []).
    useEffect(() => {
        function handleKeyWhenDown(event: KeyboardEvent) {
            if (event.key === "Escape") setIsCareerOpen(false);
        }
        // Key is hit == "Escape", do "handleKeyWhenDown" => setIsCareerOpen(false)
        document.addEventListener("keydown", handleKeyWhenDown);
    }, []);

    return (
        <>
            <nav className="main-nav">
                <div className="nav-inner">
                    {/* LEFT NAVIGATION BAR */}
                    <div className="nav-left">
                        <Link to="/" onClick={() => setIsCareerOpen(false)}>
                            <img src={logo} alt="Philip Milanov Logo" className="logo" />
                        </Link>{" "}

                        <div className="career-wrapper">
                            <button
                                type="button"
                                className="career-button"
                                onClick={() => setIsCareerOpen(!isCareerOpen)}>
                                Career
                            </button>

                            {isCareerOpen && (
                                <div className="career-dropdown">
                                    <Link to="/animation" onClick={() => setIsCareerOpen(false)}>Animation</Link>
                                    <Link to="/rigging" onClick={() => setIsCareerOpen(false)}>Rigging</Link>
                                    <Link to="/development" onClick={() => setIsCareerOpen(false)}>Development</Link>
                                    <Link to="/sports" onClick={() => setIsCareerOpen(false)}>Sports</Link>
                                </div>
                            )}
                        </div>

                        <Link to="/projects" onClick={() => setIsCareerOpen(false)}>Projects</Link>
                        <Link to="/skills" onClick={() => setIsCareerOpen(false)}>Skills</Link>
                        <Link to="/resume" onClick={() => setIsCareerOpen(false)}>Resume</Link>
                        <Link to="/about" onClick={() => setIsCareerOpen(false)}>About</Link>
                    </div>

                    {/* RIGHT NAVIGATION BAR */}
                    <div className="nav-right">
                        <Link to="/contact" onClick={() => setIsCareerOpen(false)}>Contact</Link>
                    </div>
                </div>
            </nav>

            {isCareerOpen && (
                <div className="backdrop" onClick={() => setIsCareerOpen(false)} />
            )}

            {/* Outlet are the child routes of Layout */}
            <Outlet />
        </>
    );
}   