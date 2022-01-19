import React, { Component } from 'react';
import { Route } from 'react-router';
import { Home } from './components/Home';
import { Home } from './components/Home';


import './custom.css'

function App() {
  return (
    <Router>
      <Routes>
        <Route exact path="/" element={<Home />} />
        
      </Routes>
    </Router>
  );
}

export default App;