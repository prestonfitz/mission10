import { useEffect, useState } from 'react';
import { BowingLeague } from '../types/BowlingLeague';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowingLeague[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5263/bowlingleague');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <div className="row">
      <div className="col-10 mx-auto">
        <table className="table table-bordered">
          <thead>
            <tr>
              <th>Bowler Name</th>
              <th>Team Name</th>
              <th>Address</th>
              <th>City</th>
              <th>State</th>
              <th>Zip</th>
              <th>Phone Number</th>
            </tr>
          </thead>
          <tbody>
            {bowlerData.map((b) => (
              <tr key={b.bowlerId}>
                <td>
                  {b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}
                </td>
                <td></td>
                <td>{b.bowlerAddress}</td>
                <td>{b.bowlerCity}</td>
                <td>{b.bowlerState}</td>
                <td>{b.bowlerZip}</td>
                <td>{b.bowlerPhoneNumber}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default BowlerList;
