import React from 'react';
// import logo from './logo.svg';
import './App.css';
import Header from './components/header';
import Description from './components/description';
// import LeagueData from './LeagueData';
import BowlerList from './components/bowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Bowling League Data" />
      <Description />
      {/* <LeagueData /> */}
      <BowlerList />
    </div>
  );
}

export default App;
