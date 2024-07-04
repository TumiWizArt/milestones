import { Link } from 'react-router-dom'

const Navbar = ()=>{
    return(
        <div className="navbarContainer">

            <div className="logo">
                <Link to="/"><h1>People</h1></Link>
            </div>
            
            <div className="links">
                <Link to="/">Home</Link>
                <Link to="/add">Add</Link>
            </div>
        </div>
        
    )
}

export default Navbar