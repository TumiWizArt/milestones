import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Home from './pages/home'
import Navbar from './compoments/navbar'
import Add from './pages/add';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <div className="pages">
          <Navbar/>
          <Routes>
            <Route
              path="/"
              element={<Home/>}
            />

            <Route
              path='/add'
              element={<Add/>}
            />
          </Routes>
        </div>
      </BrowserRouter>
    </div>
  );
}

export default App;
