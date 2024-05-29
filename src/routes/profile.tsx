import React from 'react';

type Props = {
    name: string;
};

export const Profile: React.FC<Props> = ({ name }) => {
    return (
        <div className="flex">
            <div>Hallo{name}</div>
            <div>Her er noe tekst</div>
        </div>
    );
};
