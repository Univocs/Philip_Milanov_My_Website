import { Link, Outlet } from "react-router-dom";

export default function LayOut() {
    return (
        <div>
            <nav>
                <Link to="/">Home</Link>{" "}
                <Link to="/animation">Animation</Link>{" "}
                <Link to="/rigging">Rigging</Link>{" "}
                <Link to="/projects">Projects</Link>{" "}
                <Link to="/resume">Resume</Link>{" "}
                <Link to="/about">About Me</Link>{" "}
                <Link to="/contact">Contact</Link>
            </nav>
        
            <Outlet>
        </div>
    );
}   