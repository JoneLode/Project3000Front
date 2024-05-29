import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { Button } from './ui/button';

type Props = {};

export const Menu: React.FC<Props> = () => {
    const navigate = useNavigate();
    return (
        <div className="w-full h-24 bg-orange-600">
            <button
                className="bg-blue-700 hover:bg-blue-900 rounded hover:text-end m-4 text-white font-bold w-minEgenKnapp"
                onClick={() => navigate('/about')}
            >
                about
            </button>
            <button onClick={() => navigate('/profile')}>profile</button>
            <button onClick={() => navigate('/admin')}>admin</button>
            <Button onClick={() => navigate('/about')} variant={'destructive'}>
                about
            </Button>
        </div>
    );
};
