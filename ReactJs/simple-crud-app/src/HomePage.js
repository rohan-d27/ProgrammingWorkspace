// @flow
import * as React from 'react';
import { Navbar } from './Components/Navbar';
import Card from './Components/Card';
export class HomePage extends React.Component {
    render() {
        return (

            <div>
                <Navbar title="This is passed title props" />
                <Card noOfCards="5"></Card>
            </div>

        );

    };
};